using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
     public interface IPresenter
    {
        void Run();
    }

    public interface IPresenter<T1, T2> 
    {
        void Run(T1 t1,T2 t2);
    }
}
