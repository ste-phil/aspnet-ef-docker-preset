using HomeApp.Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeApp.Persistence
{
    public class RepositoryDatabaseService : IRepositoryService
    {
        public readonly AppDbContext context;

        private IGenericRepository<Room, int>? roomRepository;
        private IGenericRepository<Temperature, DateTime>? temperatureRepository;

        public RepositoryDatabaseService(AppDbContext context)
        {
            this.context = context;
            this.context.Database.Migrate();
        }

        public IGenericRepository<Room, int> Rooms
        {
            get
            {
                if (roomRepository == null)
                    roomRepository = new GenericRepository<Room, int>(context);
                return roomRepository;
            }
        }
        public IGenericRepository<Temperature, DateTime> Temperatures
        {
            get
            {
                if (temperatureRepository == null)
                    temperatureRepository = new GenericRepository<Temperature, DateTime>(context);
                return temperatureRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
