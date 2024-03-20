using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Secretary  : User
    {
        public string locationClinic { get; set; }
        public User user { get; set; }
    }
}
