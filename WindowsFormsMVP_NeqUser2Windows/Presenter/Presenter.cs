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
    public class Presenter : IPresenterMain
    {
        ILoginView LoginView;
        IModel Model;
        IPresenter presenter;
        IPresenter presenter2;

        

        public Presenter(ILoginView _loginView, IModel _model)
        {
            this.Model = _model;
            this.LoginView = _loginView;
            LoginView.Enter += LoginView_Enter;
            LoginView.AddUser += LoginView_AddUser;
            LoginView.Change += LoginView_Change;
        }
        public Presenter(ILoginView _loginView, IModel _model,IPresenter _presenter)
        {
            this.Model = _model;
            this.LoginView = _loginView;
            this.presenter = _presenter;
            LoginView.Enter += LoginView_Enter;
            LoginView.AddUser += LoginView_AddUser;
            LoginView.Change += LoginView_Change;
        }
        public Presenter(ILoginView _loginView, IModel _model, IPresenter _presenter, IPresenter presenter2)
        {
            this.Model = _model;
            this.LoginView = _loginView;
            this.presenter = _presenter;
            this.presenter2 = presenter2;
            LoginView.Enter += LoginView_Enter;
            LoginView.AddUser += LoginView_AddUser;
            LoginView.Change += LoginView_Change;
        }

        private void LoginView_Change()
        {
            
        }

        private void LoginView_AddUser()
        {
            presenter.Run();
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
