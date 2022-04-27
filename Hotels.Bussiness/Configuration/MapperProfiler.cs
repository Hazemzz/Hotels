using System.Linq;
using AutoMapper;
using Hotels.Data.Models;
using Hotels.Shared.ViewModels;

namespace Hotels.Business.Configuration
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<HotelReservation, HotelReservationViewModel>()
                .ForMember(dest => dest.Code, opt => opt
                    .MapFrom(src => src.HotelReservationRooms.Select(x => x.Code).FirstOrDefault()))
                .ForMember(dest => dest.Price, opt => opt
                    .MapFrom(src => src.HotelReservationRooms.Select(x => x.Price).FirstOrDefault()));
            CreateMap<HotelReservationRooms, HotelReservationViewModel>();
        }
    }
}