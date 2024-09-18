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

        // Get Method - Select/Read data

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


    }
}
