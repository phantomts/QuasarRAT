﻿using System;
using System.Windows.Forms;

namespace Quasar.Server.Core.Helper
{
    public static class ClipboardHelper
    {
        public static void SetClipboardText(string text)
        {
            try
            {
                Clipboard.SetText(text);
            }
            catch (Exception)
            {
            }
        }
    }
}
