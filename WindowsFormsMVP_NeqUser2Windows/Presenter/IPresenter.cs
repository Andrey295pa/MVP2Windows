﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.Presenter
{
     public interface IPresenter
    {
        void Run();

       // void Run(string txt);
    }

    public interface IPresenter <T>
    {
        void Run(T arg);
    }
}
