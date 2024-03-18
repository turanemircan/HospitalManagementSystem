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
    public partial class SecretaryLoginGUI : Form
    {
        Panel panel;
        MainLoginButtons mainLoginButtons;
        public SecretaryLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }

        private void rjBtnSecretaryBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons Formuna don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }
    }
}
