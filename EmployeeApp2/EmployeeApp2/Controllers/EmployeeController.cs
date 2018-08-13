using EmployeeApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp2.Controllers
{
  [Route("api/Employee")]
  public class EmployeeController : ControllerBase
  {
    private readonly EmployeeContext _employeeContext;

    public EmployeeController(EmployeeContext employeeContext)
    {
      _employeeContext = employeeContext;

      if (_employeeContext.employees.Count() == 0)
      {
        _employeeContext.employees.Add(new EmployeeModel { Name = "Employee1" });
        _employeeContext.employees.Add(new EmployeeModel { Name = "Employee2" });
        _employeeContext.employees.Add(new EmployeeModel { Name = "Niladri", Age = 29, IsPermanent = true });
        _employeeContext.SaveChanges();
      }
    }

    [HttpGet("GetAllEmployee", Name = "GetAllEmployee")]
    public List<EmployeeModel> GetAll()
    {
      return _employeeContext.employees.ToList();
    }

    [HttpGet("GetEmployeeById/{id}", Name = "GetEmployee")]
    public IActionResult GetById(long id)
    {
      var item = _employeeContext.employees.Find(id);
      if (item == null)
      {
        return NotFound();
      }
      return Ok(item);
    }

    [HttpPost("AddEmployee", Name = "AddEmployee")]
    public IActionResult Create([FromBody] EmployeeModel employee)
    {
      if (employee == null)
      {
        return BadRequest();
      }

      _employeeContext.employees.Add(employee);
      _employeeContext.SaveChanges();

      return CreatedAtRoute("GetAllEmployee", new { id = employee.Id }, employee);
    }

    [HttpPost("UpdateEmployee/{id}", Name = "UpdateEmployee")]
    public IActionResult Update(long id, [FromBody] EmployeeModel employee)
    {
      if (employee == null || employee.Id != id)
      {
        return BadRequest();
      }

      var emply = _employeeContext.employees.Find(id);
      if (emply == null)
      {
        return NotFound();
      }

      emply.IsPermanent = employee.IsPermanent;
      emply.Name = employee.Name;
      emply.Age = employee.Age;

      _employeeContext.employees.Update(emply);
      _employeeContext.SaveChanges();
      return NoContent();
    }

    [HttpDelete("DeleteEmployee/{id}", Name= "DeleteEmployee")]
    public IActionResult Delete(long id)
    {
      var emply = _employeeContext.employees.Find(id);
      if (emply == null)
      {
        return NotFound();
      }

      _employeeContext.employees.Remove(emply);
      _employeeContext.SaveChanges();
      return Ok(_employeeContext.employees.ToList());
    }
  }
}
