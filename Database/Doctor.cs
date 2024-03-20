using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Doctor : User
    {
        public string branch { get; set; }
        public User user { get; set; }
    }
}
