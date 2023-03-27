using CsvHelper;
using EmployeeManagerSystem;
using System.Globalization;
using System.Reflection;
using System.Text;


DataService dataService = new DataService();

string projectPath = dataService.TakeProjectPath();

Department IT_DEPARTMENT = new Department() { DepartmentName = "IT" };

List<Employee> employees = new List<Employee>()
{
    new Employee() { EmployeeId = 1, Name = "Arda", Surname = "Kılıç", DepartmentOfEmployee = IT_DEPARTMENT},
    new Employee() { EmployeeId = 2, Name = "Berfin", Surname = "Nur", DepartmentOfEmployee = IT_DEPARTMENT },
};

IT_DEPARTMENT.Employees = employees;

EmployeeManager employeeManager = new EmployeeManager();
DepartmentManager departmentManager = new DepartmentManager();

Department TRADERS_DEPARTMENT = departmentManager.CreateDepartment("Traders", employees[0], employees[1], employees);
Employee CAN_ILBASAN = employeeManager.CreateEmployee(3, "Can", "İlbasan", IT_DEPARTMENT);

dataService.AppendEmployeToDatabase($@"{projectPath}\employeesdatabase.csv", CAN_ILBASAN);
dataService.AppendDepartmentToDatabase($@"{projectPath}\departmentsdatabase.csv", TRADERS_DEPARTMENT);