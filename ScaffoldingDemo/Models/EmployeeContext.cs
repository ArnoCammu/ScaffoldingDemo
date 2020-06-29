using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaffoldingDemo.Models
{
    public class EmployeeContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
