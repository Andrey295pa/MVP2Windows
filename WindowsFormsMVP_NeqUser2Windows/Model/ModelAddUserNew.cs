using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.Model
{
    public class ModelAddUserNew : IModelAddUser
    {
        public void Save(string name, string password)
        {
            System.Windows.Forms.MessageBox.Show(name,password);
        }
        //public ModelAddUserNew() { }
    }
}
