using DAL1;
using System;
EmployeeDAL dal = new EmployeeDAL();
Employee employee = new Employee { Id = 1, Name = "usman" };
dal.Save(employee);
Console.WriteLine(dal.ReadEmployee().Id);
Console.WriteLine("This is a change to my code");