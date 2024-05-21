using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Azure.Core.Pipeline;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class PALF_RandevuAl : Form
    {

        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public PALF_RandevuAl()
        {
            InitializeComponent();

        }


        void doctorgetir1()
        {
            bag.Open();


            cmd = new SqlCommand("Select *from Doctors where branch='Kulak Burun Boğaz'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);

            }
            bag.Close();
        }

        void doctorgetir2()
        {
            bag.Open();


            cmd = new SqlCommand("Select *from Doctors where branch='Beyin Cerrahi'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);

            }
            bag.Close();
        }

        void doctorgetir3()
        {
            bag.Open();


            cmd = new SqlCommand("Select *from Doctors where branch='Çocuk Hastalıkları'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);

            }
            bag.Close();
        }

        private void PALF_RandevuAl_Load(object sender, EventArgs e)
        {

        }

        private void cBoxRandevuPoliklinikSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxRandevuPoliklinikSec.Text)
            {
                case "Kulak Burun Boğaz":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir1();
                    break;

                case "Beyin Cerrahi":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir2();
                    break;

                case "Çocuk Hastalıkları":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir3();
                    break;

            }
        }
    }
}

