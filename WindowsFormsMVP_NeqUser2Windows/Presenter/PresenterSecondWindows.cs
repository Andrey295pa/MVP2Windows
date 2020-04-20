using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMVP_NeqUser2Windows.Model;
using WindowsFormsMVP_NeqUser2Windows.View;

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
    public class PresenterSecondWindows : IPresenterSecond
    {
        IModelAddUser model;
        INewUserView view;
       

        public PresenterSecondWindows(INewUserView _view, IModelAddUser _model)
        {
            this.view = _view;
            this.model = _model;
            this.view.RegUser += View_RegUser;
        }
     

        private void View_RegUser()
        {
            model.Save(view.LoginUser, view.NameUser);
        }

        public void Run()
        {
            view.Show();
           
        }
    }
}
