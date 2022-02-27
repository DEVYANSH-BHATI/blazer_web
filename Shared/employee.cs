using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_app_trial.Shared
{
    class employee
    {
        public int EmployeeID { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public DateTime DateOfBirth{ get; set; }
        public Gender Gender{ get; set; }
        public int DepartmentId{ get; set; }
        public String Photopath{ get; set; }
        public Department Department{ get; set; }
    }
}
