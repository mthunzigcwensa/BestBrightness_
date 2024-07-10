using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository User { get; }
        IProductRepository Product { get; }
        ISalesRepository Sale { get; }
        void Save();
    }
}
