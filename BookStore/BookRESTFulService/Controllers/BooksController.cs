using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRESTFulService.Data;
using BookRESTFulService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookRESTFulService.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly BookDbContext _context;

        public BooksController(BookDbContext context)
        {
            _context = context;
        }

        [HttpGet("retrieve/{pagesize}/{pageno}")]
        public async Task<Tuple<IEnumerable<Book>, Pagination>> Get(int pagesize, int pageno)
        {
            Pagination pagination = new Pagination();

            pagination.PageNo = pageno;
            pagination.PageSize = pagesize;

            var query = _context.Books.AsNoTracking().OrderBy(m => m.Title);                                                      // Prepare Query
            pagination.TotalCount = await query.CountAsync().ConfigureAwait(false);                                               // Get the Record TotalCount.

            var result = await query.Skip((pagination.PageNo - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync(); // Retrieve data based on Page No. and Page Size
            return new Tuple<IEnumerable<Book>, Pagination>(result, pagination);                                                  // Return 2 Models, Movie Model and Pagination Model            
        }

        [HttpGet("retrieve/{isbn}")]
        public async Task<Book> Get(string isbn)
        {
            var book = await _context.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Isbn == isbn);
            return (book);
        }

        [HttpGet("search/{keyword}/{pagesize}/{pageno}")]
        public async Task<Tuple<IEnumerable<Book>, Pagination>> Search(string keyword, int pagesize, int pageno)
        {
            Pagination pagination = new Pagination();

            pagination.PageNo = pageno;
            pagination.PageSize = pagesize;

            var query = _context.Books.AsNoTracking().Where(b => b.Title.ToLower().Contains(keyword.ToLower()));
            pagination.TotalCount = await query.CountAsync().ConfigureAwait(false);

            var result = await query.Skip((pagination.PageNo - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync();
            return new Tuple<IEnumerable<Book>, Pagination>(result, pagination);
        }
    }
}
