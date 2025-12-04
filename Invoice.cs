using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }


        public DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }
    }
}
