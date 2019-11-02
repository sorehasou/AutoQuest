using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AutoQuest.UserScript
{
    public class ModuleLoader
    {
        public List<ScriptInfo> Scripts = new List<ScriptInfo>();

        public void Init()
        {
            Scripts.Clear();

            var assembly = Assembly.GetExecutingAssembly();
            var resources = assembly.GetManifestResourceNames();
            var modulespace = $"{GetType().Namespace}.Module.";

            foreach (var resource in resources)
            {
                if (!resource.StartsWith(modulespace)) continue;

                var stream = assembly.GetManifestResourceStream(resource);
                using (var reader = new StreamReader(stream))
                {
                    var info = new ScriptInfo();
                    var script = reader.ReadToEnd();

                    if (info.TryParse(script))
                    {
                        Scripts.Add(info);
                    }
                }
            }
        }

        public ScriptInfo[] GetScripts(string url)
        {
            return Scripts.Where(info => info.IsMatchUrl(url)).ToArray();
        }
    }
}
