using BB.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Application.Common.Utility
{
    public static class SD
    {
        public const string Role_SalesPerson = "SalesPerson";
        public const string Role_Admin = "Admin";
        public static List<SaleVM> SaleVMList { get; set; } = new List<SaleVM>();

    }
}
