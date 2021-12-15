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
        //ID int Identity(1,1) primary key,
        //EventID int foreign key references Events(EventID),
        //UserID int not null
        // GET: Favorites
        public async Task<IActionResult> Index()
        {
            return View(await _context.Favorites.ToListAsync());
        }

        // GET: Favorites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favorites = await _context.Favorites
                .FirstOrDefaultAsync(m => m.ID == id);
            if (favorites == null)
            {
                return NotFound();
            }

            return View(favorites);
        }

        // GET: Favorites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Favorites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EventID,UserID")] Favorites favorites)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favorites);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(favorites);
        }

        // GET: Favorites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favorites = await _context.Favorites.FindAsync(id);
            if (favorites == null)
            {
                return NotFound();
            }
            return View(favorites);
        }

        // POST: Favorites/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EventID,UserID")] Favorites favorites)
        {
            if (id != favorites.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favorites);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavoritesExists(favorites.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(favorites);
        }

        // GET: Favorites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favorites = await _context.Favorites
                .FirstOrDefaultAsync(m => m.ID == id);
            if (favorites == null)
            {
                return NotFound();
            }

            return View(favorites);
        }

        // POST: Favorites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favorites = await _context.Favorites.FindAsync(id);
            _context.Favorites.Remove(favorites);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavoritesExists(int id)
        {
            return _context.Favorites.Any(e => e.ID == id);
        }
    }
}
