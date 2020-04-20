using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using WindowsFormsMVP_NeqUser2Windows.View;
using WindowsFormsMVP_NeqUser2Windows.Model;
using WindowsFormsMVP_NeqUser2Windows.Presenter;

namespace WindowsFormsMVP_NeqUser2Windows
{
    public class LibraryModul : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoginView>().To<Form1>();
            Bind<INewUserView>().To<Form2>();
            Bind<IChangeView>().To<Form3>();
            Bind<IModelMain>().To<Model.Model>();
            Bind<IModelAddUser>().To<ModelAddUserNew>();
            Bind<IModelChange>().To<ModelChange>();
            Bind<IPresenterMain>().To<Presenter.Presenter>();
            Bind<IPresenterSecond>().To<PresenterSecondWindows>();
            Bind<IPresenterChange>().To<PresenterChange>();

        }
    }
}
