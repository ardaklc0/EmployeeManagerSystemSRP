using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerSystem
{
    internal class DepartmentManager
    {
        public Department CreateDepartment(string DepartmentName)
        {
            return new Department() { DepartmentName = DepartmentName};
        }

        public Department CreateDepartment(string DepartmentName, Employee ProductOwner, Employee Director, List<Employee> Employees)
        {
            return new Department() { DepartmentName = DepartmentName, ProductOwner = ProductOwner, Director = Director, Employees = Employees };
        }

        public void ChangeProductOwner(Department department, Employee newProductOwner)
        {
            department.ProductOwner = newProductOwner;
        }

        public void ChangeDirector(Department department, Employee newDirector)
        {
            department.Director = newDirector;
        }

        public void AddEmployeeToDepartment(Department department, Employee newEmployee)
        {
            department.Employees.Add(newEmployee);
        }
    }
}
