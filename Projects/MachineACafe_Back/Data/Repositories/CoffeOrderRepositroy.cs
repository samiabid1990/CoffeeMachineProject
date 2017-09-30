using Data.Infrastructure;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CoffeOrderRepositroy : RepositoryBase<CoffeOrder>, ICoffeOrderRepositroy
    {
        public CoffeOrderRepositroy(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }

    }
    public interface ICoffeOrderRepositroy : IRepository<CoffeOrder>
    {

    }
}
