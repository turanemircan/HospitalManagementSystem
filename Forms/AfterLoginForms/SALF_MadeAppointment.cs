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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HospitalManagementSystem.Database;
using System.Diagnostics;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class SALF_MadeAppointment : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public SALF_MadeAppointment()
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

                cboxdoktorSek.Items.Add(reader[1] + " " + reader[2]);

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

                cboxdoktorSek.Items.Add(reader[1] + " " + reader[2]);

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

                cboxdoktorSek.Items.Add(reader[1] + " " + reader[2]);

            }
            bag.Close();
        }

        private void cBoxRandevuPoliklinikSecSek_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxRandevuPoliklinikSecSek.Text)
            {
                case "Kulak Burun Boğaz":
                    cboxdoktorSek.Items.Clear();
                    cboxdoktorSek.Text = string.Empty;
                    doctorgetir1();
                    break;

                case "Beyin Cerrahi":
                    cboxdoktorSek.Items.Clear();
                    cboxdoktorSek.Text = string.Empty;
                    doctorgetir2();
                    break;

                case "Çocuk Hastalıkları":
                    cboxdoktorSek.Items.Clear();
                    cboxdoktorSek.Text = string.Empty;
                    doctorgetir3();
                    break;

            }
        }

        public void saatkontrol(string doctorName, DateTime date, string saat, string pid)
        {

            doctorName = cboxdoktorSek.Text;
            saat = cbSaat.Text;
            date = dtpRandevuTarihSec.Value;
            DateOnly dateonly = DateOnly.FromDateTime(date);
            pid = textboxSALF_PatientId.Text;


            // SQL bağlantısını açın
            bag.Open();

            // SQL sorgusunu hazırlayın
            string query = "SELECT COUNT(*) FROM Appointments WHERE DoctorName = @DoctorName AND AppointmentTime = @AppointmentTime AND AppointmentDate = @AppointmentDate";

            // SqlCommand nesnesini oluşturun
            using (SqlCommand cmd = new SqlCommand(query, bag))
            {
                // Parametreleri ekleyin
                cmd.Parameters.AddWithValue("@DoctorName", doctorName);
                cmd.Parameters.AddWithValue("@AppointmentTime", saat);
                cmd.Parameters.AddWithValue("@AppointmentDate", dateonly);


                // Sorguyu çalıştırın ve sonucu alın
                int count = (int)cmd.ExecuteScalar();

                // Sonucu kontrol edin ve uygun işlemleri yapın
                if (count > 0)
                {
                    // Aynı saat için zaten bir randevu var
                    MessageBox.Show("Bu doktor için bu saatte zaten bir randevu var.");
                }
                else
                {


                    string insertQuery = "INSERT INTO Appointments (DoctorName, AppointmentDate, AppointmentTime,PatientID) VALUES (@DoctorName, @AppointmentDate, @AppointmentTime,@PatiID)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, bag))
                    {
                        // Parametreleri ekleyin
                        insertCmd.Parameters.AddWithValue("@DoctorName", doctorName);
                        insertCmd.Parameters.AddWithValue("@AppointmentDate", dateonly);
                        insertCmd.Parameters.AddWithValue("@AppointmentTime", saat);
                        insertCmd.Parameters.AddWithValue("@PatiID", pid);


                        // INSERT sorgusunu çalıştırın
                        insertCmd.ExecuteNonQuery();
                    }





                    MessageBox.Show("Randevu alındi.");
                }
            }


            bag.Close();
        }

        private void ButtonSALF_MakeAnAppointment_Click(object sender, EventArgs e)
        {
            saatkontrol(cboxdoktorSek.Text, dtpRandevuTarihSec.Value, cbSaat.Text, textboxSALF_PatientId.Text);
        }
    }
}
