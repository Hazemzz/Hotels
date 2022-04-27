using System;

namespace Hotels.Shared.ViewModels
{
    public class HotelReservationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookingReferenceNumber { get; set; }
        public HotelReservationStatus Status { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOuDate { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
    }
}
