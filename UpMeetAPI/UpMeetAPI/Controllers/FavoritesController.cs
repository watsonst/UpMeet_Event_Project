using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UpMeetAPI.Data;
using UpMeetAPI.Models;

namespace UpMeetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoritesController : Controller
    {
        private readonly UpMeetAPIContext _context;

        public FavoritesController(UpMeetAPIContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("New")]
        public async Task<IActionResult> CreateFavorite([Bind("EventID,UserID")] Favorites favorites)
        {

            favorites.EventID = favorites.EventID;
            favorites.UserID = favorites.UserID;
            

            await _context.AddAsync(favorites);
            await _context.SaveChangesAsync();

            var result = new OkObjectResult(favorites);
            return result;

        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetFavorites()
        {
            var favorites = await _context.Favorites.ToListAsync();

            var result = new OkObjectResult(favorites);
            return result;

        }

        [HttpDelete]
        [Route("Remove")]
        public async Task<IActionResult> RemoveFavorite(int id)
        {
            var favorite = await _context.Favorites.FirstOrDefaultAsync(m => m.ID == id);
            if (favorite == null)
            {
                return new OkResult();
            }
            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();

            var result = new OkResult();
            return result;
        }
    }
}
