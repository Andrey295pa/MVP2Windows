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
    public partial class Form1 : Form,ILoginView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Name
        {
            set => txtLogin.Text=value;
            get=> txtLogin.Text;
        }
        public string Password
        {
            set => txtPassword.Text = value;
            get => txtPassword.Text;
        }

        public event Action Enter;
        public event Action AddUser;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Enter != null)
            {
                Enter.Invoke();
            }
            
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();
            if (AddUser != null)
            {
                AddUser.Invoke();
            }
        }
        public new void Show()
        {
            Application.Run(this);
        }

       
    }
}
