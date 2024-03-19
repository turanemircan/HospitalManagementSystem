using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Doctor : User
    {
        private string? _branch;

        public string? branch { get { return _branch; } }
        
    }
}
