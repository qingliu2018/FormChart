﻿using System;
using System.Windows.Forms;

using KeLi.FormChart.Forms;

namespace KeLi.FormChart
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}