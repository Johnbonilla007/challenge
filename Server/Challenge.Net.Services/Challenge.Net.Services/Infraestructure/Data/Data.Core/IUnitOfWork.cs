using System;

namespace Challenge.Net.Services.Infraestructure.Data.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}