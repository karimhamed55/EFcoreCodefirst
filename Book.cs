using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class Book
    {
       public string Title { get; set; }
        public string Author { get; set; }
        public int Bookid { get; set; }

        public ICollection<EmployeeBook> Employees { get; set; }
    }
}
