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
    public partial class DoctorLoginGUI : Form
    {
        Panel panel;

        Helper.Helper helper;
        LoginGUI loginGUI;

        MainLoginButtons loginButtons;
        public DoctorLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public DoctorLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }

        private void rjBtnDoctorBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons'a geri don ve paneli ilet.
            Helper.Helper helper = new Helper.Helper(panel);
            loginButtons = new MainLoginButtons(panel);
            helper.formGoster(loginButtons, loginButtons.Name);
        }

        private void rjBtnDoctorSignIn_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper();
            bool kullanıcıKontrol = helper.IsValidUser("Name", "Surname");
            if(kullanıcıKontrol)
            {
                DoctorALF doctorALF = new DoctorALF();
                doctorALF.Show();
                loginGUI.Hide();
            }
        }
    }
}
