using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMVP_NeqUser2Windows.Model;
using WindowsFormsMVP_NeqUser2Windows.View;
using WindowsFormsMVP_NeqUser2Windows.

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
    public class PresenterChange : IPresenterChange
    {
        IModel model;
        IChangeView change;

        public PresenterChange() { }

        public PresenterChange(IModel model, IChangeView changeView) 
        {
            this.model = model;
            this.change = changeView;
            this.change.SaveChange += Change_SaveChange;
        }

        private void Change_SaveChange()
        {
            model.Save(change.NameChange(),change.PasswordChange());
        }

        public void Run()
        {
            change.Show();
        }
    }
}
