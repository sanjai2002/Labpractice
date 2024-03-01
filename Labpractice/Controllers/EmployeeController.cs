using Labpractice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labpractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static  List<Employee> Employeedetails= new List<Employee>() { };


        [HttpPost]
        public ActionResult PostEmployee(Employee employee)
        {
            Employeedetails.Add(employee);
            return Ok(employee);

        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            return  Employeedetails;
        }



    }
}
