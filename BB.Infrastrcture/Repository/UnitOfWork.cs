using BB.Application.Common.Interfaces;
using BB.Infrastrcture.Data;

namespace BB.Infrastrcture.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductRepository Product { get; private set; }
        public IApplicationUserRepository User { get; private set; }
        public ISalesRepository Sale { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            User = new ApplicationUserRepository(_db);
            Product = new ProductRepository(_db);
            Sale = new SalesRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
