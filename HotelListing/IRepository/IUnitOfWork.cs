using HotelListing.Data;
using HotelListing.IRepository;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Country> Coutries { get; }

        IGenericRepository<Hotel> Hotels { get; }

        Task Save();
    }
}
