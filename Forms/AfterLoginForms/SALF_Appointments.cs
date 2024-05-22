using Microsoft.Data.SqlClient;
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
    public partial class SALF_Appointments : Form
    {
        public SALF_Appointments()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public void randevuGetir()
        {
            DataGridSALF_Appointments.DataSource = null;


            bag.Open();
            string query = "SELECT * FROM Appointments ";

            using (SqlCommand cmd = new SqlCommand(query, bag))
            {


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridSALF_Appointments.DataSource = dt;
                }
            }

            bag.Close();
        }

        private void DataGridSALF_Appointments_MouseEnter(object sender, EventArgs e)
        {
            randevuGetir();
        }
    }
}
