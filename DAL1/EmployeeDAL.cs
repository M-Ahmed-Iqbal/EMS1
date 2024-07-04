using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
namespace DAL1
{
    public class EmployeeDAL
    {
        public void Save(Employee employee)
        {

            FileStream fin = new FileStream("data.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fin);
            string data = $" {employee.Id}, {employee.Name}";
            streamWriter.WriteLine(data);
            streamWriter.Close();
            fin.Close();


        }


        public Employee ReadEmployee()
        {
            FileStream fout = new FileStream("data.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fout);
            string data = streamReader.ReadLine();
            string[] employeeData = data.Split(",");
            Employee employee = new Employee();
            employee.Id = int.Parse(employeeData[0]);
            employee.Name = employeeData[1];
            streamReader.Close();
            fout.Close();
            return employee;
        }

        public List<Employee> ReadAll()
        {

            List<Employee> list = new List<Employee>();

            while (true)
            {
                Employee employee = ReadEmployee();
                list.Add(employee);


            }
        }
    }
}
