using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class EmployeeBook
    {
        public int ID { get; set; }
        public int employeeid {  get; set; }

        public int bookid { get; set; }

        public Employee Employee { get; set; }
        public Book Book { get; set; }

    }
}
