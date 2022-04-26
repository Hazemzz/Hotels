using System.Collections.Generic;
using System.Threading.Tasks;
using Hotels.Shared.Helper;
using Hotels.Shared.ViewModels;

namespace Hotels.Business.Repository.Interface
{
    public interface IHotelReservationRepository
    {
        HotelReservationViewModel GetById(int id);
        Task<IEnumerable<HotelReservationViewModel>> GetAll();
        Task<IEnumerable<HotelReservationViewModel>> FilterHotelReservations(Filtering filtering);
    }
}
