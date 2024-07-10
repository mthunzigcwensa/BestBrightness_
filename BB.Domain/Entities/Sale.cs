using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Domain.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int QuantitySold { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public DateTime DateSold { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public string SalesPersonId { get; set; }        
        public ApplicationUser User { get; set; }
    }
}
