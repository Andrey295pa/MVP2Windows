using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMVP_NeqUser2Windows.Model
{
    public class Model : IModel
    {
        private string writePath { set; get; }
        public void Save(string name, string password)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(name + " " + password);
                }
                System.Windows.Forms.MessageBox.Show("Add ok");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public Model()
        {
             writePath = @"C:\Users\Andrey\Desktop\SomeText2.txt";
        }
    }
}
