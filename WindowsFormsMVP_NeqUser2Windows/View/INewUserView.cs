using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.View
{
    public interface INewUserView: IView
    {
        string NameUser { set; get; }
        string LoginUser { set; get; }
        string PasswordUser { set; get; }

        event Action RegUser;
    }
}
