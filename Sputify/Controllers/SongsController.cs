using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sputify.Models;

namespace Sputify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly SputifyContext _context;

        public SongsController(SputifyContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Song>>> GetSongs()
        {
            return await _context.Songs.ToListAsync();
        }

        // GET: api/Songs/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Song>> GetSong(int id)
        {
            var song = await _context.Songs.FindAsync(id);

            if (song == null)
            {
                return NotFound();
            }

            return song;
        }

        // Get api/Songs/nameOfSong - regex skulle have de forventede tegn inklussive mellemrum
        [HttpGet("{name:Regex(^[[a-zA-Z% ']]*$)}")]
        public async Task<ActionResult<IEnumerable<Song>>> GetSongs(string name)
        {
            List<Song> songResult = new List<Song>();
            List<Song> songList = await _context.Songs.ToListAsync();
            for (int i = 0; i < songList.Count; i++)
            {
                //||
                if (songList[i].SongName.ToLower().Contains(name.ToLower()))
                {
                    songResult.Add(songList[i]);
                }
            }
            if (songResult == null)
            {
                return NotFound();
            }

            return songResult;
        }

        // PUT: api/Songs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSong(int id, Song song)
        {
            if (id != song.SongID)
            {
                return BadRequest();
            }

            _context.Entry(song).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SongExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Songs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Song>> PostSong(Song song)
        {
            _context.Songs.Add(song);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSong", new { id = song.SongID }, song);
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Song>> DeleteSong(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }

            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();

            return song;
        }

        private bool SongExists(int id)
        {
            return _context.Songs.Any(e => e.SongID == id);
        }
    }
}
