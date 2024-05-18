using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Forms.LoginForms;

namespace HospitalManagementSystem.Forms
{
    public partial class PatientSignUpGUI : Form
    {
        Panel panel;
        PatientLoginGUI patientLoginGUI;
        LoginGUI _loginGUI;
        public PatientSignUpGUI(Panel _panel, LoginGUI loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            _loginGUI = loginGUI;
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            //PatientLoginGUI Form'una git ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            patientLoginGUI = new PatientLoginGUI(panel, _loginGUI);
            helper.formGoster(patientLoginGUI, patientLoginGUI.Name);
        }

        private void rjTextBoxPatientName_Load(object sender, EventArgs e)
        {

        }

        private void PatientSignUpGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
