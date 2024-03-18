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
        public PatientSignUpGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            //PatientLoginGUI Form'una git ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            patientLoginGUI = new PatientLoginGUI(panel);
            helper.formGoster(patientLoginGUI, patientLoginGUI.Name);
        }
    }
}
