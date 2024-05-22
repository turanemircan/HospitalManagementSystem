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
    public partial class AALF_DoctorReviews : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public AALF_DoctorReviews()
        {
            InitializeComponent();
        }
        public void randevuGetir()
        {
            dataGridViewAALF_DoctorReviews.DataSource = null;


            bag.Open();
            string query = "SELECT * FROM Appointments ";

            using (SqlCommand cmd = new SqlCommand(query, bag))
            {


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAALF_DoctorReviews.DataSource = dt;
                }
            }

            bag.Close();
        }

        private void dataGridViewAALF_DoctorReviews_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            randevuGetir();
        }
    }
}
