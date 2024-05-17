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
    public partial class DoctorALF : Form
    {
        Helper.Helper helper;

        DALF_Bilgilerim dalf_bilgilerim;
        DALF_RandevuGörüntüle dalf_randevuGörüntüle;

        public DoctorALF()
        {
            InitializeComponent();
        }

        private void buttonDALF_ViewAppointment_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            dalf_randevuGörüntüle = new DALF_RandevuGörüntüle();
            helper.formGoster(dalf_randevuGörüntüle, dalf_randevuGörüntüle.Name);
        }

        private void DoctorALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DoctorALF_Load(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            dalf_bilgilerim = new DALF_Bilgilerim();
            helper.formGoster(dalf_bilgilerim, dalf_bilgilerim.Name);
        }

        private void buttonDALF_İnformation_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            dalf_bilgilerim = new DALF_Bilgilerim();
            helper.formGoster(dalf_bilgilerim, dalf_bilgilerim.Name);
        }
    }
}
