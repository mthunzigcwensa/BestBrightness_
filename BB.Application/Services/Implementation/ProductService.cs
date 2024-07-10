using BB.Application.Common.Interfaces;
using BB.Application.Services.Interfaces;
using BB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Application.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            _unitOfWork.Product.Add(product);
            _unitOfWork.Save();
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var amenity = _unitOfWork.Product.Get(u => u.Id == id);

                if (amenity != null)
                {

                    _unitOfWork.Product.Remove(amenity);
                    _unitOfWork.Save();
                    return true;
                }
                else
                {
                    throw new InvalidOperationException($"Product with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _unitOfWork.Product.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _unitOfWork.Product.Get(u => u.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            _unitOfWork.Product.Update(product);
            _unitOfWork.Save();
        }
    }
}
