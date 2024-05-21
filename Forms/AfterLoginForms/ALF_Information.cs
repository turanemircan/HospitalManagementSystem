using HospitalManagementSystem.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class ALF_Information : Form
    {
        Panel panel;
        ALF_PasswordUpdate _ALF_PasswordUpdate;
        public ALF_Information()
        {
            InitializeComponent();
        }
        public ALF_Information(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
            _ALF_PasswordUpdate = new ALF_PasswordUpdate(panel);
        }

        private void linkLabelPasswordUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.Helper helper = new Helper.Helper(panel);
            ALF_PasswordUpdate aLF_PasswordUpdate = new ALF_PasswordUpdate(panel);
            helper.formGoster(aLF_PasswordUpdate, aLF_PasswordUpdate.Name);
        }

        private void textboxALF_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxALF_Id);
        }

        private void textboxALF_GSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxALF_GSM);
        }
        private void ALF_Information_Load(object sender, EventArgs e)
        {
        }
    }
}
