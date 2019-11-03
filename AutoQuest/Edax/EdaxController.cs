using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AutoQuest.Edax
{
    public static class EdaxController
    {
        public static Process EdaxProcess;

        public static string FilePath = $"{AppDomain.CurrentDomain.BaseDirectory}wEdax.exe";

        public static Action<string> Reciever;

        public static void Init(int mode, Action<string> reciever)
        {
            Reciever = reciever;

            if (EdaxProcess == null)
            {
                Start();
            }

            WriteLine("n 1");
            WriteLine("level 22");
            WriteLine("mode " + mode);
            WriteLine("init");
        }

        public static void Start()
        {
            EdaxProcess = new Process();
            EdaxProcess.StartInfo.FileName = FilePath;
            EdaxProcess.StartInfo.RedirectStandardOutput = true;
            EdaxProcess.StartInfo.RedirectStandardInput = true;
            EdaxProcess.StartInfo.CreateNoWindow = true;
            EdaxProcess.StartInfo.UseShellExecute = false;
            EdaxProcess.Start();

            Task.Run(() =>
            {
                while (true) Reciever?.Invoke(ReadLine());
            });
        }

        public static void WriteLine(string value)
        {
            EdaxProcess.StandardInput.WriteLine(value);
        }

        public static string ReadLine()
        {
            return EdaxProcess.StandardOutput.ReadLine();
        }
    }
}
