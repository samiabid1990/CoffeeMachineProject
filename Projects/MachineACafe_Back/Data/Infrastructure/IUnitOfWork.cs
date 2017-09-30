using Data.Repositories;
using System;


namespace Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        ICoffeOrderRepositroy CoffeOrderRepositroy { get; }
    }
}

