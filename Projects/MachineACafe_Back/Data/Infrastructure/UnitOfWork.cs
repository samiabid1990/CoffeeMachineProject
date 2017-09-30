using System;
using Data.Repositories;


namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext dataContext;
        protected ApplicationDbContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }

        private ICoffeOrderRepositroy coffeOrderRepositroy;
        public ICoffeOrderRepositroy CoffeOrderRepositroy
        {
            get { return coffeOrderRepositroy = new CoffeOrderRepositroy(dbFactory); }
        }

        public void Dispose()
        {
            DataContext.Dispose();
        }

    }
}
