using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMVP_NeqUser2Windows.Presenter;
using Ninject;
using Ninject.Modules;

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
            //Presenter.PresenterSecondWindows presenter2 = new PresenterSecondWindows(new Form2(), new Model.ModelAddUserNew());
            //Presenter.Presenter presenter = new Presenter.Presenter(new Form1(), new Model.Model(),presenter2);
            //presenter.Run();

            var kernel = new StandardKernel(new LibraryModul());
            var presenterMain = kernel.Get<Presenter.Presenter>();
            presenterMain.Run();
        }
    }
}
