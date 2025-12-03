using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class Customers
    {
        [Key]
        public int customer_id { get; set; }
        public string customer_name { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
