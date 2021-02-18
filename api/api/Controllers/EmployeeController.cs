using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bl;
using dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using model.dal;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository repo;
        public EmployeeController(IEmployeeRepository _repo)
        {
            this.repo = _repo;
        }
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            BEmployee be = new BEmployee(this.repo);

            return be.getEmployee();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            BEmployee be = new BEmployee(this.repo);

            return be.getEmployee(id) ;
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
