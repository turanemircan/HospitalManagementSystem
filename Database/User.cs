using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class User
    {
        public User() { }
        
        private int _id;
        private string _name;
        private string _surname;
        private string _identification;
        private string _GSM_No;
        private string _password;

        public int id { get { return _id; } }
        public string name { get { return _name; } }
        public string surname { get { return _surname; } }
        public string identification { get { return _identification; } }
        public string GSM_No { get { return _GSM_No; } }
        public string password { get { return _password; } }


    }
}
