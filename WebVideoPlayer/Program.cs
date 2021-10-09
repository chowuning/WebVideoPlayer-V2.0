/*
 * File Name:WebVideoPalyer(WVP)
 * Designer Name:Lee Cheng Yu 
 * Designer Number:16(School Number)
 * Language Tools:C#
 */
using System;
using System.Windows.Forms;

namespace WebVideoPlayer
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
