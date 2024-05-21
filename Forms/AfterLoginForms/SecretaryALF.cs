using HospitalManagementSystem.Database;
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

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class SecretaryALF : Form
    {
        SALF_Appointments appointments;
        ALF_Information myinformation;
        SALF_MadeAppointment madeAppointment;

<<<<<<< HEAD
        public string secretaryId {  get; set; }   
        public string secretaryName { get; set; }  
        
        public string secretarySurname {  get; set; }

        Helper.Helper helper;
        public SecretaryALF(string _secretaryId, string _secretaryName,string _secretarySurname)
        {
            InitializeComponent();
            this.secretaryId = _secretaryId;
            this.secretaryName = _secretaryName;
            this.secretarySurname=_secretarySurname;
            
=======
        public Secretary secretary { get; set; }

        Helper.Helper helper;
        public SecretaryALF(Secretary secretary)
        {
            InitializeComponent();
            this.secretary = secretary;
>>>>>>> 6b13874dc77df92b4db4f490875d8d7797ecffd5
        }

        private void SecretaryALF_Load(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            madeAppointment = new SALF_MadeAppointment();
            helper.formGoster(madeAppointment, madeAppointment.Name);
            label2.Text=secretaryId.ToString();
            label4.Text=secretaryName.ToString()+" "+secretarySurname.ToString();

        }

        private void SecretaryALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SALF_MainPageMakeAppointments_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            madeAppointment = new SALF_MadeAppointment();
            helper.formGoster(madeAppointment, madeAppointment.Name);
        }

        private void SALF_MainPageAppointments_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            appointments = new SALF_Appointments();
            helper.formGoster(appointments, appointments.Name);

        }

        private void SALF_MainPageInformation_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            myinformation= new ALF_Information(panelSecretaryAlf, secretary);
            helper.formGoster(myinformation, myinformation.Name);
        }
    }
}
