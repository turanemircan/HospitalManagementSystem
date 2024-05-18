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
    public partial class ALF_PasswordUpdate : Form
    {
        Panel panel;
        public ALF_PasswordUpdate()
        {
            InitializeComponent();
        }
        public ALF_PasswordUpdate(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper(panel);
            PALF_Bilgilerim pALF_Bilgilerim = new PALF_Bilgilerim(panel);
            helper.formGoster(pALF_Bilgilerim, pALF_Bilgilerim.Name);
        }
    }
}
