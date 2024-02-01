using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApplication.Models
{
    /// <summary>
    /// Business logic to get the data of employee. This is usually to get the data from Database.
    /// </summary>
    public class EmployeeBusinessLogic
    {
        public Employee GetEmployee(int employeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = employeeId,
                Name = "Harshil",
                Address = "Markham",
                City = "Winnipeg",
                Gender = "Male"
            };

            return employee;
        }
    }
}