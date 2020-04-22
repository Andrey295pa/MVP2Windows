using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMVP_NeqUser2Windows.Model;
using WindowsFormsMVP_NeqUser2Windows.View;

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
    public class PresenterChange : IPresenterChange<string,string>
    {
        IModelChange model;
        IChangeView change;
        string name;
        string password;

        public PresenterChange() { }

        public PresenterChange(IModelChange model, IChangeView changeView) 
        {
            this.model = model;
            this.change = changeView;
            this.change.SaveChange += Change_SaveChange;
        }

        private void Change_SaveChange()
        {
            model.Save(name,password);
        }

        public new void Run(string a, string b)
        {
            this.name = a;
            this.password = b;
            change.Show();
        }

    }
}
