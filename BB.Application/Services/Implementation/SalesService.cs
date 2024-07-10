using BestBrightness.Application.Common.Interfaces;
using BestBrightness.Application.Services.Interfaces;
using BestBrightness.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBrightness.Application.Services.Implementation
{
    public class SalesService : ISalesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateSale(Sale sale)
        {
            ArgumentNullException.ThrowIfNull(sale);

            _unitOfWork.Sale.Add(sale);
            _unitOfWork.Save();
        }

        public bool DeleteSale(int id)
        {
            try
            {
                var sale = _unitOfWork.Sale.Get(u => u.Id == id);

                if (sale != null)
                {

                    _unitOfWork.Sale.Remove(sale);
                    _unitOfWork.Save();
                    return true;
                }
                else
                {
                    throw new InvalidOperationException($"sale with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _unitOfWork.Sale.GetAll(includeProperties: "Product,User");
        }

        public Sale GetSaleById(int id)
        {
            return _unitOfWork.Sale.Get(u => u.Id == id);
        }

        public void UpdateSale(Sale sale)
        {
            ArgumentNullException.ThrowIfNull(sale);

            _unitOfWork.Sale.Update(sale);
            _unitOfWork.Save();
        }
    }
}
