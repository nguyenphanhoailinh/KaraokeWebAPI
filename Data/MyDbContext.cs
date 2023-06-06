using KARAOKEAPIWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace KARAOKEAPIWEB.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region DbSet

        public DbSet<KaraokeRoom> karaokeRooms { get; set; }
        public DbSet<BookRoom> bookRooms { get; set; }
       
        #endregion

    }
}
