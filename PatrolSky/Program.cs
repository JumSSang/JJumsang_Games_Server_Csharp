using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrolSky
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Server.start(7800);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UIManager.Instacne.form = new Form1();
            Application.Run(UIManager.Instacne.form);
        }
    }
}
