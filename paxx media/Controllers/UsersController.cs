using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;
using paxx_media.Models;

namespace paxx_media.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _datacontext;

        // constructor

        public UsersController(DataContext datacontext)
        {
            _datacontext = datacontext;

        }

        // Get :api/users

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _datacontext.Users.ToListAsync();
        }

        // GET: api/users/{id}

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _datacontext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: api/users
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _datacontext.Users.Add(user);
            await _datacontext.SaveChangesAsync();

            // Return the newly created user along with the route to access it
            return CreatedAtAction(nameof(GetUser), new { id = user.ID }, user);
        }

        // PUT: api/users/{id}

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _datacontext.Entry(user).State = EntityState.Modified;

            try
            {
                await _datacontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        private bool UserExists(int id)
        {
            return _datacontext.Users.Any(e => e.ID== id);

        }

        // DELETE: api/users/{id}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _datacontext.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _datacontext.Users.Remove(user);
            await _datacontext.SaveChangesAsync();

            return NoContent();
        }

        private bool user(int id)
        {
            return _datacontext.Users.Any(e => e.ID == id);
        }




    }
}
