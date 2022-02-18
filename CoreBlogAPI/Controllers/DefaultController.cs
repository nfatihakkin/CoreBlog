using CoreBlogAPI.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            using var c = new Context();
            c.Add(e);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee e)
        {
            using var c = new Context();
            var emp = c.Find<Employee>(e.EmployeeID);
            if(emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.EmployeeName = e.EmployeeName;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
