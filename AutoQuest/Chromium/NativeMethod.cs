using AutoQuest.Edax;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Threading.Tasks;

namespace AutoQuest.Chromium
{
    public class NativeMethod
    {
        public static bool IsOneMinuteMode = false;

        public ChromiumWebBrowser CEFEngine;

        public Random Random = new Random();

        public void StartOthello(int mode)
        {
            EdaxController.Init(mode, EdaxPlays);
        }

        [JavascriptIgnore]
        public async void EdaxPlays(string line)
        {
            if (line.StartsWith("Edax plays"))
            {
                var map = "ABCDEFGH";
                var x = map.IndexOf(line[11]);
                var y = int.Parse(line[12].ToString()) - 1;
                var eval = "$('div.square[data-x=" + x + "][data-y=" + y + "]').click()";
                // Console.WriteLine(x + ", " + y);

                if (IsOneMinuteMode) await Task.Delay(1000);
                else await Task.Delay(1000 + Random.Next(2000));

                CEFEngine.ExecuteScriptAsync(eval);
            }
        }

        public void Play(string point)
        {
            if (point.StartsWith("-")) point = "ps";
            EdaxController.WriteLine(point);
        }
    }
}
