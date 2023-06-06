
using KARAOKEAPIWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KARAOKEAPIWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
       /* private readonly MyDbContext _context;*/

       /* public MenuController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult GetAll()
        {
            try
            {
                var menu = _context.Menus.ToList();
                return Ok(menu);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var menu = _context.Menus.SingleOrDefault(lo => lo.IdMenu == id);
            if (menu != null)
            {
                return Ok(menu);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public IActionResult CreateNew(MenuModel model)
        {
            try
            {
                var menu = new Menu
                {
                    Name = model.Name,
                    Price=model.Price,
                };
                _context.Add(menu);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, menu);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateLoaiById(int id, MenuModel model)
        {
            var menu = _context.Menus.SingleOrDefault(lo => lo.IdMenu == id);
            if (menu != null)
            {
                menu.Name = model.Name;
                menu.Price = model.Price;

                _context.SaveChanges();
                return NoContent();
            }
            else { return NotFound(); }

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLoaiById(int id)
        {
            var menu = _context.Menus.SingleOrDefault(lo => lo.IdMenu == id);
            if (menu != null)
            {
                _context.Remove(menu);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            else
            {
                return NotFound();
            }

        }*/
    }
}
