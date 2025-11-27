using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [MaxLength(5, ErrorMessage = "Max len can't be > 5 chrs")]
        public string DepartmentName { get; set; }

        public string? Description { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }
}
