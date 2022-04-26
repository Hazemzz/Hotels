using System;
using System.ComponentModel;

namespace Hotels.Shared.Helper
{
    public class Filtering
    {
        public DateTime? CheckInDateFrom{ get; set; }
        public DateTime? CheckInDateTo { get; set; }
        public string? BookingReferenceNumber { get; set; }
        public DateTime? ReservationDateFrom { get; set; }
        public DateTime? ReservationInDateTo { get; set; }
        [DefaultValue(PaymentStatus.Paid)]
        public PaymentStatus PaymentStatus { get; set; }
        public double? PriceFrom { get; set; }
        public double? PriceTo { get; set; }
    }
}
