using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp2.Models
{
  public class EmployeeModel
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsPermanent { get; set; }
  }
}
