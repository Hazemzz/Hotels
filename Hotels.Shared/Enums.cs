using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Shared
{
    /// <summary>
    /// Date time compare enum
    /// </summary>
    public enum DateTimeCompareTypeEnum
    {
        GreaterThan = 1,
        LessThan = 2,
        GreaterThanOrEqual = 3,
        LessThanOrEqual = 4
    }

    public enum HotelReservationStatus
    {
        Pending = 1,
        Confirmed = 2,
        Cancelled = 3 
    }

    public enum HotelReservationRoomsStatus
    {

    }
}
