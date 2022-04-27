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
        Pending,
        [Display(Name = "Paid")]
        Paid ,
        [Display(Name = "Cancelled")]
        Cancelled,
        [Display(Name = "Failed")]
        Failed
    }
}
