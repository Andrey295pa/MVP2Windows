using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMVP_NeqUser2Windows.Presenter;

namespace WindowsFormsMVP_NeqUser2Windows
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Presenter.Presenter presenter = new Presenter.Presenter(new Form1(), new Model.Model());
            presenter.Run();
        }
    }
}
