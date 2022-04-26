using System.Collections;
using System.Threading.Tasks;
using Hotels.Business.Repository.Interface;
using Hotels.Shared.Helper;
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
        [HttpPost("GetData")]
        public async Task<IEnumerable> Get([FromBody] Filtering filter)
        {
            return await _hotelReservationRepository.FilterHotelReservations(filter);
        }
    }
}
