using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMVP_NeqUser2Windows.Model;
using WindowsFormsMVP_NeqUser2Windows.View;

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
    public class Presenter : IPresenter
    {
        ILoginView LoginView;
        IModel Model;

        public Presenter(ILoginView _loginView, IModel _model)
        {
            this.Model = _model;
            this.LoginView = _loginView;
            LoginView.Enter += LoginView_Enter;
            LoginView.AddUser += LoginView_AddUser;
        }

        private void LoginView_AddUser()
        {
            PresenterSecondWindows presenterSecond = new PresenterSecondWindows(new Form2(), new ModelAddUserNew());
           // presenterSecond.Run();
           
        }

        private void LoginView_Enter()
        {
            if(LoginView.Name!="" && LoginView.Password !="")
            {
                Model.Save(LoginView.Name, LoginView.Password);
            }
            
        }

        public void Run()
        {
            LoginView.Show();
        }
    }
}
