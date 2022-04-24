using System;

namespace Hotels.Data.Models
{
    public class HotelReservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookingReferenceNumber { get; set; }
        public double PaidAmount { get; set; }
        public string Status { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOuDate { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
