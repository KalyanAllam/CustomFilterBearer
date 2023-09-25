using CustomFilterBearer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomFilterBearer.Controllers
{
    public class EmployeeController : ApiController
    {

        List<Employee> employees;

       

            public EmployeeController()
        {
            employees = new List<Employee>();
            employees.Add(new Employee { ID = 1, Name = "John" });
            employees.Add(new Employee { ID = 2, Name = "Kerry" });


        }
        [Filters.CustomAuthentication]
        public IEnumerable<Employee> Get()
        { return employees; }


    }



}
