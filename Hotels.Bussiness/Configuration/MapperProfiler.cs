using AutoMapper;
using Hotels.Data.Models;
using Hotels.Shared.ViewModels;

namespace Hotels.Business.Configuration
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<HotelReservation, HotelReservationViewModel>();
            CreateMap<HotelReservationRooms, HotelReservationViewModel>();
        }
    }
}