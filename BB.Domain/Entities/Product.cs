using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Originalquantity { get; set; }

        public int Remainingquantity { get; set; }
        public Double price { get; set; }

        [NotMapped]
        public int PecantageOfRemainingQuantity
        {
            get
            {
                return Originalquantity == 0 ? 0 : (Remainingquantity * 100 / Originalquantity);
            }
        }
    }
}
