using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using paxx_media.Models;

namespace paxx_media.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly DataContext _datacontext;

        // constructor

        public ReviewsController(DataContext datacontext)
        {
            _datacontext = datacontext;

        }

        // GET: api/review

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            return await _datacontext.Reviews.ToListAsync();
        }

        // GET: api/review
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            var review = await _datacontext.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // POST: api/review
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            // Add the new review to the DbSet
            _datacontext.Reviews.Add(review);
            await _datacontext.SaveChangesAsync();

            // Return the newly created review along with the URL to access it
            return CreatedAtAction(nameof(GetReview), new { id = review.ID }, review);
        }

        // PUT: api/review
        [HttpPut("{id}")]
        
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.ID)
            {
                return BadRequest();
            }

            _datacontext.Entry(review).State = EntityState.Modified;

            try
            {
                await _datacontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))  // Corrected: Check if the review does NOT exist
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

        private bool ReviewExists(int id)
        {
            return _datacontext.Reviews.Any(e => e.ID == id);
        }


        // DELETE: api/review/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _datacontext.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _datacontext.Reviews.Remove(review);
            await _datacontext.SaveChangesAsync();

            return NoContent();
        }

    }
}

