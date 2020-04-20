using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMVP_NeqUser2Windows.Presenter;

namespace WindowsFormsMVP_NeqUser2Windows
{
    public class Adapter
    {
        public Dictionary<int,IPresenter> Pairs;

        public Adapter()
        {
            Pairs = new Dictionary<int, IPresenter>();
            Pairs.Add(0,new  Presenter.Presenter(new Form1(), new Model.Model()));
            Pairs.Add(1, new PresenterSecondWindows(new Form2(), new Model.ModelAddUserNew()));
            Pairs.Add(2, new PresenterChange());
        }
    }
}
