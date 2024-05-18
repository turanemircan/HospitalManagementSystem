using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Forms.AfterLoginForms;

namespace HospitalManagementSystem.Forms.LoginForms
{
    public partial class PatientLoginGUI : Form
    {
        Panel panel;
        LoginGUI LoginGUI;

        MainLoginButtons mainLoginButtons;
        PatientSignUpGUI patientSignUpGUI;
        Helper.Helper helper;
        public PatientLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public PatientLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.LoginGUI = _loginGUI;
        }
        private void rjBtnPatientBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons'a geri don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel,LoginGUI);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnPatientSignUp_Click(object sender, EventArgs e)
        {
            // PatientSignUpGUI'a git ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            patientSignUpGUI = new PatientSignUpGUI(panel, LoginGUI);
            helper.formGoster(patientSignUpGUI, patientSignUpGUI.Name);
        }

        private void rjBtnPatientSignIn_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panel);
            bool kullaniciKontrol = helper.IsValidUser("kullanici1", "sifre123");
            if (kullaniciKontrol)
            {
                PatientALF patientALF = new PatientALF();
                patientALF.Show();
                LoginGUI.Hide();
            }
        }

    }
}
