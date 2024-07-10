using BB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Application.Services.Interfaces
{
    public interface ISalesService
    {
        IEnumerable<Sale> GetAllSales();
        void CreateSale(Sale sale);
        void UpdateSale(Sale sale);
        Sale GetSaleById(int id);
        bool DeleteSale(int id);
    }
}
