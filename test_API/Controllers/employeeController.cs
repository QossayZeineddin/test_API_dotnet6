using test_API.Models;
using test_API.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<employee>> getAll()
        {
            return employeeService.getAllEmployee();
        }

        [HttpGet("{id}")]
        public ActionResult<employee> GetById(double id)
        {
            var employee = employeeService.getById(id);
            if (employee == null)
                return NotFound();
            return employee;
        }

        [HttpPost]
        public ActionResult add(employee employee)
        {
            employeeService.add(employee);
            return CreatedAtAction(nameof(add), new { id = employee.id }, employee);
        }

        [HttpDelete("{id}")]
        public ActionResult delete(double id)
        {
            var emp = employeeService.getById(id);
            if (emp is null)
                return NotFound();
            employeeService.delete(id);
            return NoContent();
        }


        [HttpPut("{id}")]
        public ActionResult update(double id, employee employee)
        {
            if (id != employee.id)
                return BadRequest();

            var emp = employeeService.getById(id);
            if (emp == null) return NotFound();
            employeeService.update(employee);
            return NoContent();
        }
    }
}