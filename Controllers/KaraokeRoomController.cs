using KARAOKEAPIWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KARAOKEAPIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaraokeRoomController : ControllerBase
    {
        public static List<KaraokeRoom> karaokeRooms = new List<KaraokeRoom>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(karaokeRooms);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var karaokeroom = karaokeRooms.SingleOrDefault(k => k.Id == Guid.Parse(id));
                if(karaokeroom == null)
                {
                    return NotFound();
                }
                return Ok(karaokeroom);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(KaraokeRoomVM karaokeroomVM)
        {
            var karaokeroom = new KaraokeRoom()
            {
                Id = Guid.NewGuid(),
                TenQuan = karaokeroomVM.TenQuan,
                DiaChi = karaokeroomVM.DiaChi,
                Img = karaokeroomVM.Img,
                SucChua = karaokeroomVM.SucChua,
                MoTa = karaokeroomVM.MoTa,
                Menu = karaokeroomVM.Menu,
            };
             karaokeRooms.Add(karaokeroom);
            return Ok(new
            {
                Success = true,
                Data = karaokeroom
            });
        }
        [HttpPut("{id}")]
        public IActionResult Edit(string id ,KaraokeRoom karaokeRoomEdit)
        {
            try
            {
                var karaokeroom = karaokeRooms.SingleOrDefault(k => k.Id == Guid.Parse(id));
                if(karaokeroom == null)
                {
                    return NotFound();
                } 
                if(id !=karaokeroom.Id.ToString())
                {
                    return BadRequest();
                }
                karaokeroom.TenQuan = karaokeRoomEdit.TenQuan;
                karaokeroom.DiaChi = karaokeRoomEdit.DiaChi;
                karaokeroom.Img = karaokeRoomEdit.Img;
                karaokeroom.SucChua = karaokeRoomEdit.SucChua;
                karaokeroom.MoTa = karaokeRoomEdit.MoTa;
                karaokeroom.Menu=karaokeRoomEdit.Menu;
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
                var karaokeroom = karaokeRooms.SingleOrDefault(hh => hh.Id == Guid.Parse(id));
                if (karaokeroom == null)
                {
                    return NotFound();
                }
                //delete

                karaokeRooms.Remove(karaokeroom);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
