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
    public partial class PatientLoginGUI : Form
    {
        Panel panel;
        MainLoginButtons mainLoginButtons;
        PatientSignUpGUI patientSignUpGUI;
        public PatientLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        private void rjBtnPatientBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons'a geri don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnPatientSignUp_Click(object sender, EventArgs e)
        {
            // PatientSignUpGUI'a git ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            patientSignUpGUI = new PatientSignUpGUI(panel);
            helper.formGoster(patientSignUpGUI, patientSignUpGUI.Name);
        }
    }
}
