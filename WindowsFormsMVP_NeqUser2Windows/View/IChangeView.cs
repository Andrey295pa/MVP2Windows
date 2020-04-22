using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.View
{
    public interface IChangeView:IView
    {
        string NameChange { set; get; }
        string PasswordChange { set; get; }
        string LoginChange { set; get; }

        event Action SaveChange;
    }
}
