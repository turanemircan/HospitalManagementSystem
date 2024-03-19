using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Patient : User
    {
        public Patient() { }

        private string _againPassword;
        public string againPassword { get { return _againPassword; } }
    }
}
