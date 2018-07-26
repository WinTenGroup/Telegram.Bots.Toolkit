﻿using System;
using System.Windows.Forms;
using Telegram.Bots.Toolkit.Views;

namespace Telegram.Bots.Toolkit
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAwal());
        }
    }
}