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
    public partial class AdminLoginGUI : Form
    {
        Panel panel;
        LoginGUI loginGUI;
        MainLoginButtons mainLoginButtons;
        public AdminLoginGUI(Panel _panel,LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            //MainLoginButtons Formuna don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel,loginGUI);
            helper.formGoster(mainLoginButtons,mainLoginButtons.Name);
        }
    }
}
