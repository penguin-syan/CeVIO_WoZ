using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CeVIO_WoZ
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// 

        //高DPI画面に対応するため、必要な関数を読み込み？
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


        [STAThread]
        static void Main()
        {
            //高DPI画面に対応するため、何かを設定
            SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
