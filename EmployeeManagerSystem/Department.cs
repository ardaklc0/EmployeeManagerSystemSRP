using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerSystem
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public Employee ProductOwner { get; set; }
        public Employee Director { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
