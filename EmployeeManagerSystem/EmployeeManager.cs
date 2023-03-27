using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerSystem
{
    public class EmployeeManager
    {
        public Employee CreateEmployee(int EmployeeId, string Name, string Surname, Department DepartmentOfEmployee)
        {
            return new Employee() 
            { 
              EmployeeId = EmployeeId,
              Name = Name,
              Surname = Surname,
              DepartmentOfEmployee = DepartmentOfEmployee
            };
        }

        public void ChangeEmployeeId(Employee employee, int newEmployeeId)
        {
            employee.EmployeeId = newEmployeeId;
        }

        public void ChangeEmployeeName(Employee employee, string newEmployeeName)
        {
            employee.Name = newEmployeeName;
        }

        public void ChangeEmployeeSurname(Employee employee, string newEmployeeSurname)
        {
            employee.Surname = newEmployeeSurname;
        }

        public void ChangeEmployeeDepartment(Employee employee, Department newEmployeeDepartment)
        {
            employee.DepartmentOfEmployee = newEmployeeDepartment;
        }
    }
}
