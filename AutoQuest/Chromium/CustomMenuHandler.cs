using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoQuest.Chromium
{
    public class CustomMenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        { 
            if (model.Count > 0)
            {
                model.AddSeparator();
            }

            var mode = NativeMethod.IsOneMinuteMode ? 5 : 1;
            model.AddItem((CefMenuCommand)26501, $"{mode}分モードに変更");
        }

        public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == (CefMenuCommand)26501)
            {
                if (NativeMethod.IsOneMinuteMode)
                {
                    NativeMethod.IsOneMinuteMode = false;
                    browserControl.Load("http://wars.fm/reversi?lang=ja");
                }
                else
                {
                    NativeMethod.IsOneMinuteMode = true;
                    browserControl.Load("http://wars.fm/reversi1?lang=ja");
                }
                return true;
            }

            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
