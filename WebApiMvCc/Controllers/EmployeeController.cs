using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiMvCc.Models;

namespace WebApiMvCc.Controllers
{
    public class EmployeeController : ApiController
    {
        static List<Employee> Employees = new List<Employee>()
        {
            new Employee() {ID=1,Name="Person 1"},
            new Employee() {ID=2,Name="Person 2"},
            new Employee() {ID=3,Name="Person 3"},
        };

        public IEnumerable<Employee> Get()
        {
            return Employees;
        }
        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(e => e.ID == id);
        }
        [Route("api/Employee/{id}/tasks")]
        public IEnumerable<string>GetEmployeeTasks(int id)
        {
            switch (id)
            {
                case 1:
                    return new List<string> { "task1-1", "task1-2", "task1-3" };
                case 2:
                    return new List<string> { "task2-1", "task2-2", "task2-3" };
                case 3:
                    return new List<string> { "task3-1", "task3-2", "task3-3" };
                default:
                    return null;
            }
        }
    }
}
