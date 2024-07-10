using BB.Application.Common.Interfaces;
using BB.Domain.Entities;
using BB.Infrastrcture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Infrastrcture.Repository
{
    internal class SalesRepository : Repository<Sale>, ISalesRepository
    {
        private readonly ApplicationDbContext _db;

        public SalesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Sale entity)
        {
            _db.Sales.Update(entity);
        }
    }
}
