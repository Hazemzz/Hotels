namespace Hotels.Data.Models
{
    public class HotelReservationRooms
    {
        public int Id { get; set; }
        public int HotelReservationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public bool IsRefundable { get; set; }
    }
}
