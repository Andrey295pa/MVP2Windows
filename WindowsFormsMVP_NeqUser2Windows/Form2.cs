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
    public partial class Form2 : Form, INewUserView
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string NameUser {
            get => txtRegName.Text;
            set => txtRegName.Text = value; }
        public string LoginUser {
            get => txtRegLogin.Text;
            set => txtRegLogin.Text = value;
        }
        public string PasswordUser {
            get => txtRegPassword.Text;
            set => txtRegPassword.Text = value;
        }

        public event Action RegUser;

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (RegUser != null)
            {
                RegUser.Invoke();
            }
        }
        public new void Show()
        {
            Application.Run(this);
            
            
        }
    }
}
