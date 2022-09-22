
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnowboarderModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SnowboarderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly SnowboardContext _context;
        public PlayerController(SnowboardContext context)
        {
            _context = context;
        }

        // GET: api/<PlayerController>
        [HttpGet]
        public List<Player> Get()
        {
            return _context.Player.ToList();
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return _context.Player.Find(id);           
        }

        // POST api/<PlayerController>
        [HttpPost]
        public void Post([FromBody] Player player)
        {
            _context.Player.Add(player);           
            _context.SaveChanges();
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Player player)
        {
            if (player.PlayerId != id)
            {
                return;
            }

            if (_context.Player.AsNoTracking() != null)
            {
                _context.Player.Update(player);
                _context.SaveChanges();                
            }            
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Player.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}
