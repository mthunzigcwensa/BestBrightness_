using BB.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Domain.ViewModels
{
    public class SaleVM
    {
        public Sale? sale {  get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? productList { get; set; }
    }
}
