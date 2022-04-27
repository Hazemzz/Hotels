using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hotels.Shared;

namespace Hotels.Data.Models
{
    public class HotelReservation
    {
        public HotelReservation()
        {
            HotelReservationRooms = new HashSet<HotelReservationRooms>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookingReferenceNumber { get; set; }
        public double PaidAmount { get; set; }
        [Required]
        public HotelReservationStatus Status { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOuDate { get; set; }
        [Required]
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime ReservationDate { get; set; }
        public virtual ICollection<HotelReservationRooms> HotelReservationRooms { get; set; }
        
    }
}
