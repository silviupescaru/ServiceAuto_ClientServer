using ServiceAuto_Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAuto_Client.View
{
    public partial class LoginGUI : Form, ILoginGUI
    {
        private ControllerLogin loginController;

        public LoginGUI()
        {
            InitializeComponent();
            this.loginController = new ControllerLogin(this);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.loginController.Login();
        }

        public string Username
        {
            get { return this.textBoxUsername.Text; }
            set { this.textBoxUsername.Text = value; }
        }

        public string Password
        {
            get { return this.textBoxPassword.Text; }
            set { this.textBoxPassword.Text = value; }
        }
    }
}
