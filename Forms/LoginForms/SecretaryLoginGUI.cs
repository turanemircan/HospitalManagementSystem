using HospitalManagementSystem.Forms.AfterLoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.LoginForms
{
    public partial class SecretaryLoginGUI : Form
    {
        Panel panel;
        LoginGUI loginGUI;
        MainLoginButtons mainLoginButtons;
        public SecretaryLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public SecretaryLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }
        private void rjBtnSecretaryBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons Formuna don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnSecretarySignIn_Click(object sender, EventArgs e)
        {
            Helper.Helper helper= new Helper.Helper(panel);
            bool userControl = helper.IsValidUser("user", "user1");
            if (userControl)
            {
                SecretaryALF secretaryALF = new SecretaryALF();
                secretaryALF.Show();
                loginGUI.Hide();

            }
        }
    }
}
