using System;
using System.Collections.Generic;
using VogCodeChallenge.Business.Interfaces;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Business.Services
{
    public class EmployeeService : IEmployee
    {

        public IEnumerable<Employee> GetAll()
        {
            try
            {
               return CreateEmployeesData();
            }
            catch (Exception ex)
            {
                // we can log the exception
                throw;
            }
        }

        public IList<Employee> ListAll()
        {
            try
            {
                return CreateEmployeesData();
            }
            catch (Exception ex)
            {
                // we can log the exception
                throw;
            }
        }
        
        public List<Employee> CreateEmployeesData()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee
            {
                FirstName = "Tushar",
                LastName = "Borchate",
                MailingAddress = "North York",
                JobTitle = Entities.Enums.JobTitle.SoftwareDeveloper,
                Id = 1,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                FirstName = "Mark",
                LastName = "Elliot",
                MailingAddress = "North York",
                JobTitle = Entities.Enums.JobTitle.Manager,
                Id = 2,
                DepartmentId=2
            };
            employees.Add(employee);
            return employees;
        }
    }
}
