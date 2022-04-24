using System;

namespace Hotels.Shared.ViewModels
{
    public class HotelReservationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookingReferenceNumber { get; set; }
        public string Status { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOuDate { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
    }
}
