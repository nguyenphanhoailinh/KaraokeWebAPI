using System.Reflection;

namespace KARAOKEAPIWEB.Models
{
    public class KaraokeRoomVM
    {
        public string TenQuan { get; set; } = null!;
        public string DiaChi { get; set; } = null!;

        public string Img { get; set; } = null!;

        public string SucChua { get; set; } = null!;

        public string  MoTa { get; set; } = null!;

        public MenuModel Menu { get; set; } = null!;


    }
    public class KaraokeRoom : KaraokeRoomVM
    {   
        public Guid Id { get; set; }
    }
}
