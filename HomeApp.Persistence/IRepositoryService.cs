using HomeApp.Library.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HomeApp.Persistence
{
    public interface IRepositoryService
    {
        IGenericRepository<Room, int> Rooms { get; }
        IGenericRepository<Temperature, DateTime> Temperatures { get; }

        void Save();
    }

}