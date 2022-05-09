using System.ComponentModel.DataAnnotations;

namespace Hotels.Shared
{
    public enum HotelReservationStatus
    {
        Pending = 1,
        Confirmed = 2,
        Cancelled = 3 
    }

    public enum PaymentStatus
    {
        [Display(Name = "Pending")]
        Pending = 1,
        [Display(Name = "Paid")]
        Paid = 2,
        [Display(Name = "Cancelled")]
        Cancelled = 3,
        [Display(Name = "Failed")]
        Failed = 4
    }
}
