using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms.LoginForms;

namespace HospitalManagementSystem.Forms
{
    public partial class PatientSignUpGUI : Form
    {
        Helper.PasswordHasher hasher;
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

        private void rjBtnPatientSignUp_Click(object sender, EventArgs e)
         {
            hasher = new Helper.PasswordHasher();
            string deneme = rjTextBoxPatientName.Text;
            if (!string.Equals(textBoxP_AgainPassword.Text,textBoxP_Password.Text))
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = hasher.HashPassword(textBoxP_Password.Text);
                using(var context = new HospitalDbContext())
                {
                    Patient newPatient = new Patient
                    {
                        name = textBoxPatientName.Text,
                        surname = textBoxPatientSurname.Text,
                        identification = textBoxP_IdentificationNo.Text,
                        GSM_No = textBoxP_GSM_No.Text,
                        password = hashedPassword,
                        againPassword = hashedPassword
                    };
                    context.Patients.Add(newPatient);
                    context.SaveChanges();
                    MessageBox.Show("Registration successful. You will be redirected to the login screen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
        }
    }
}
