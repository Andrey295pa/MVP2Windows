using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.View
{
    public interface ILoginView :IView
    {
        string Name { set; get; }
        string Password { set; get; }
        event Action Enter;
        event Action AddUser;
        event Action Change;
    }
}
