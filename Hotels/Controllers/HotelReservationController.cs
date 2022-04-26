using System.Collections;
using System.Threading.Tasks;
using Hotels.Business.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelReservationController : ControllerBase
    {
        private readonly IHotelReservationRepository _hotelReservationRepository;

        public HotelReservationController(IHotelReservationRepository iHotelReservationRepository)
        {
            _hotelReservationRepository = iHotelReservationRepository;
        }

        // GET: api/HotelReservation
        [HttpGet("GetAll")]
        public async Task<IEnumerable> Get()
        {
            var result = await _hotelReservationRepository.GetAll();
            return result;
        }
    }
}
