using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace AutoQuest.UserScript
{
    public class ScriptInfo
    {
        public string JavaScript = "";

        public NameValueCollection Options;

        public string this[string name]
        {
            get { return Options[name]; }
            set { Options[name] = value; }
        }

        public bool TryParse(string js)
        {
            JavaScript = js;

            var blockPattern = "\\/\\/ ==UserScript==(.*?)\\/\\/ ==\\/UserScript==";
            var blockMatch = Regex.Match(js, blockPattern, RegexOptions.Singleline);

            if (!blockMatch.Success) return false;

            var options = blockMatch.Groups[1].Value;

            var optionPattern = "@([\\w-]+)\\s+(.+)\\r";
            var optionMatches = Regex.Matches(options, optionPattern);
            var optionCollection = new NameValueCollection();

            foreach (var match in optionMatches.Cast<Match>())
            {
                var name = match.Groups[1].Value;
                var value = match.Groups[2].Value;
                optionCollection[name] = value;
            }

            Options = optionCollection;

            return true;
        }

        public bool IsMatchUrl(string url)
        {
            return LikeOperator.LikeString(url, this["match"], CompareMethod.Binary);
        }
    }
}
