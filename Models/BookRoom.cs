using System.Data;

namespace KARAOKEAPIWEB.Models
{
    public class BookRoomN
    {
        public string name {  get; set; }

        public int phone { get; set; }

        public DateTime day { get; set; }

        public int people { get; set; }

        public DateTime BookingDate { get; set; }
        public KaraokeRoom room { get; set; }
        public int roomId { get; set; }
       /* public virtual ICollection<KaraokeRoom> KaraokeRooms { get; set; } = null!;*/
    }

    public class BookRoom :BookRoomN
    {
        public Guid Id { get; set; }
    }
   

}
