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
        public PatientLoginGUI(Panel _panel)
        {
            InitializeComponent();    
            this.panel = _panel;
        }
        public PatientLoginGUI()
        {
            InitializeComponent();
        }

        private void rjBtnPatientBackMain_Click(object sender, EventArgs e)
        {
        }
    }
}
