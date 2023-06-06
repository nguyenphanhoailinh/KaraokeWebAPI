using KARAOKEAPIWEB.Data;
using KARAOKEAPIWEB.Migrations;
using KARAOKEAPIWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KARAOKEAPIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookRoomController : ControllerBase
    {
        public static List<BookRoom> bookRooms = new List<BookRoom>();
        private readonly MyDbContext _context;

        public BookRoomController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(bookRooms);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                var bookroom = bookRooms.SingleOrDefault(br => br.Id == Guid.Parse(id));
                if (bookroom == null)
                {
                    return NotFound();
                }
                return Ok(bookroom);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Create(/*[FromBody]*/ BookRoomN bookRoomN/*, [FromBody] KaraokeRoom karaokeRoom*/ )
        {
            try
            {
                var bookroom = new BookRoom()

                {
                    Id = Guid.NewGuid(),
                    name = bookRoomN.name,
                    phone = bookRoomN.phone,
                    day = bookRoomN.day,
                    people = bookRoomN.people,
                    /*roomId=Guid.NewGuid(),*/

                    /*roomId = bookRoomN.roomId.Equals(karaokeRoom.Id).ToString()*/

                    BookingDate=DateTime.Now,
                    /*roomId = bookRoomN.roomId,*/
                    roomId=1,


                };
                _context.bookRooms.Add(bookroom);
                _context.SaveChanges();
                return Ok(bookroom);
            }
            catch
            {
                return BadRequest();
            }
          
          
        }
        [HttpPut("{id}")]
        public IActionResult Edit(string id, BookRoom bookRoomEdit)
        {
            try
            {
                var bookroom = bookRooms.SingleOrDefault(br => br.Id == Guid.Parse(id));
                if (bookroom == null)
                {
                    return NotFound();
                }
                if (id != bookroom.Id.ToString())
                {
                    return BadRequest();
                }
                bookroom.name = bookRoomEdit.name;
                bookroom.phone = bookRoomEdit.phone;
                bookroom.day = bookRoomEdit.day;
                bookroom.people = bookRoomEdit.people;
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {


                //LINQ [object] Query
                var bookroom = bookRooms.SingleOrDefault(br => br.Id == Guid.Parse(id));
                if (bookroom == null)
                {
                    return NotFound();
                }
                //delete

                bookRooms.Remove(bookroom);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }

   
  
}
