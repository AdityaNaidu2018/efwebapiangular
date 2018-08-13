using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp2.Models
{
  public class EmployeeContext:DbContext
  {
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {

    }

    public DbSet<EmployeeModel> employees { get; set; }
  }
}
