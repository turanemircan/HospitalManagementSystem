using HospitalManagementSystem.Database;
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
    public partial class DALF_RandevuGörüntüle : Form
    {
        HospitalDbContext context;
        public DALF_RandevuGörüntüle()
        {
            InitializeComponent();
            context = new HospitalDbContext();
        }

        private void textboxDALF_PatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxDALF_PatientId);
        }

        private void buttonDALF_Save_Click(object sender, EventArgs e)
        {
            using (HospitalDbContext context = new HospitalDbContext())
            {
                if (textboxDALF_PatientId.Text != "")
                {
                    int patientId = Convert.ToInt32(textboxDALF_PatientId.Text);
                    //var appointments = context.Appointments.Where(a => a.PatientID = patientId).ToList();
                    //dataGridViewDALF_Appointments.DataSource = appointments;
                }
                else
                {
                    MessageBox.Show("Lütfen bir hasta ID'si giriniz.");
                }
            }
        }

        private void DALF_RandevuGörüntüle_Load(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper();
            helper.loadDataPatients(dataGridViewDALF_Appointments, context);
        }
    }
}
