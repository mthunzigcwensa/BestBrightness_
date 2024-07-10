using BB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB.Application.Common.Interfaces
{
    public interface ISalesRepository : IRepository<Sale>
    {
        void Update(Sale entity);
    }
}
