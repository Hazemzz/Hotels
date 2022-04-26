using Hotels.Business.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Hotels.Data;
using Hotels.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Business.Repository.Class
{
    public class HotelReservationRepository : IHotelReservationRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapperProfiler;
        public HotelReservationRepository(AppDbContext appDbContext, IMapper mapperProfiler)
        {
            _appDbContext = appDbContext;
            _mapperProfiler = mapperProfiler;
        }
        public HotelReservationViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HotelReservationViewModel>> GetAll()
        {
            var hotelReservations = await _appDbContext.HotelReservation
                .ProjectTo<HotelReservationViewModel>(_mapperProfiler.ConfigurationProvider).ToListAsync();
            return _mapperProfiler.Map<IEnumerable<HotelReservationViewModel>>(hotelReservations);
        }
    }
}
