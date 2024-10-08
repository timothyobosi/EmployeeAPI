using System;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        // Using the required modifier (C# 11 or later)
        public required string EmployeeId { get; set; }
        public required string EmployeeFirstName { get; set; }
        public required string EmployeeLastName { get; set; }
        public DateTime EmployeeDateOfBirth { get; set; }

        // include a constructor 
        public Employee(string employeeId, string employeeFirstName, string employeeLastName, DateTime employeeDateOfBirth)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeDateOfBirth = employeeDateOfBirth;
        }
    }
}
