using System.Net;
using Book1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly BookContent _dbContext;

        public ValuesController(BookContent dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]


        public async Task<ActionResult<IEnumerable<Book12>>> GetBooks()
        {
            if (_dbContext.Books == null)
            {
                return NotFound();
            }
            return await _dbContext.Books.ToListAsync();
        }

        [HttpGet("{BookId}")]
        public async Task<ActionResult<Book12>> GetBook(int BookId)
        {
            if (_dbContext.Books == null)
            {
                return NotFound();
            }
            var book1 = await _dbContext.Books.FindAsync(BookId);
            if (book1 == null)
            {
                return NotFound();
            }
            return book1;
        }

        [HttpPost]
        public async Task<ActionResult<Book12>> PostBook(Book12 book1)
        {
            _dbContext.Books.Add(book1);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { BookId = book1.BookId }, book1);
        }
        [HttpPut]
        public async Task<IActionResult> PutBook(int BookId, Book12 book1)
        {
            if (BookId != book1.BookId)
            {
                return BadRequest();
            }

            _dbContext.Entry(book1).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!Brandavailable(BookId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();

        }
        private bool Brandavailable(int BookId)
        {
            return (_dbContext.Books?.Any(x => x.BookId == BookId)).GetValueOrDefault();
        }
        [HttpDelete("{BookId}")]
        public  async Task<IActionResult> DeleteBook12(int BookId)
        {
            if (_dbContext.Books == null)
            {
                return NotFound();
            }

            var book1 = await _dbContext.Books.FindAsync(BookId);
            if (book1 == null)
            {
                return NotFound();
            }
            _dbContext.Books.Remove(book1);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
