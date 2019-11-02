using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoQuest
{
    public partial class MainForm : Form
    {
        public static UserScript.ModuleLoader UserScripts;

        public static ChromiumWebBrowser CEFEngine;

        public MainForm()
        {
            InitializeComponent();
            InitializeUserScript();
            InitializeCefSharp();
        }

        public void InitializeUserScript()
        {
            UserScripts = new UserScript.ModuleLoader();
            UserScripts.Init();
        }

        public void InitializeCefSharp()
        {
            var browserSettings = new BrowserSettings
            {
                DefaultEncoding = "UTF-8",
                JavascriptAccessClipboard = CefState.Enabled,
                JavascriptCloseWindows = CefState.Disabled,
                JavascriptDomPaste = CefState.Disabled,
                SansSerifFontFamily = "Meiryo"
            };

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            var cefSettings = new CefSettings();
            var current = AppDomain.CurrentDomain.BaseDirectory;
            cefSettings.CachePath = $@"{current}data";

            Cef.Initialize(cefSettings);

            CEFEngine = new ChromiumWebBrowser("http://wars.fm/reversi?lang=ja");

            CEFEngine.BrowserSettings = browserSettings;
            CEFEngine.Dock = DockStyle.Fill;
            CEFEngine.RegisterJsObject("autoQuest", new Chromium.NativeMethod());
            CEFEngine.FrameLoadEnd += CEFEngine_FrameLoadEnd;
            cefsharpArea.Controls.Add(CEFEngine);
        }

        private void CEFEngine_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            var scripts = UserScripts.GetScripts(e.Url);

            foreach (var script in scripts)
            {
                CEFEngine.InvokeOnUiThreadIfRequired(() =>
                    CEFEngine.ExecuteScriptAsync(script.JavaScript));
            }
        }

        private void デバッグツール表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEFEngine.ShowDevTools();
        }

        private void alertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

