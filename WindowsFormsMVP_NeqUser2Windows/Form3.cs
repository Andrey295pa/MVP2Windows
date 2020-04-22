
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMVP_NeqUser2Windows.View;

namespace WindowsFormsMVP_NeqUser2Windows
{
    public partial class Form3 : Form, IChangeView
    {
        public string NameChange
        {
            set => txtNameChange.Name = value;
            get => txtNameChange.Name;
        }
        public string PasswordChange
        {
            set => txtPasswordChange.Name = value;
            get => txtPasswordChange.Name;
        }
        public string LoginChange
        {
            set => txtLoginChange.Name = value;
            get => txtLoginChange.Name;
        }

        public event Action SaveChange;
         public Form3()
        {
            InitializeComponent();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (SaveChange != null)
            {
                SaveChange.Invoke();
            }
        }

        public new void Show()
        {
            this.ShowDialog();
        }
    
    }
}
