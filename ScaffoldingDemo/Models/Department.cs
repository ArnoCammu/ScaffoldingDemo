using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScaffoldingDemo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [MaxLength(50)]
        public string DepartmentName { get; set; }
    }
}
