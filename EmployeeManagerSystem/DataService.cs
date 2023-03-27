using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EmployeeManagerSystem
{
    public class DataService
    {

        private StreamWriter CreateWriter(string connectionPath)
        {
            return new StreamWriter(connectionPath, true, Encoding.UTF8);
        }

        private CsvWriter CreateCsvWriter(StreamWriter writer)
        {
            return new CsvWriter(writer, CultureInfo.InvariantCulture);
        }

        public string TakeProjectPath()
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            int index = projectPath.IndexOf("\\bin");
            if (index > 0)
            {
                projectPath = projectPath.Substring(0, index);
            }
            return projectPath;
        }

        public void AppendEmployeToDatabase(string connectionPath, Employee employee)
        {

            using (StreamWriter writer = CreateWriter(connectionPath))
            using (CsvWriter csv = CreateCsvWriter(writer))
            {
                csv.WriteRecord(employee);
            }
        }

        public void AppendDepartmentToDatabase(string connectionPath, Department department)
        {
            using (StreamWriter writer = CreateWriter(connectionPath))
            using (CsvWriter csv = CreateCsvWriter(writer))
            {
                csv.WriteRecord(department);
            }
        }


    }
}
