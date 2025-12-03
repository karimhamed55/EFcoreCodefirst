using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }
        [ForeignKey("Customers")]
        public int? customer_id { get; set; }

        public Customers Customer { get; set; }

    }
}
