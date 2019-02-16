using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreFrontEnd.Models;
using BookStoreFrontEnd.Helper;

namespace BookStoreFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        BookAPI bookApi;

        public HomeController()
        {
            bookApi = new BookAPI();
        }

        // For Retrive Book List and Search Book List
        [Route("{pageno=1}")]
        [HttpGet]
        public async Task<IActionResult> Index(int pageno, String keyword = null)
        {
            Pagination pagination = new Pagination();

            ViewBag.keyword = keyword;

            pagination.PageNo = pageno;

            if (!String.IsNullOrWhiteSpace(keyword))
            {
                var receiveData = await bookApi.SearchBook<Tuple<IEnumerable<BookStoreFrontEnd.Models.Book>, BookStoreFrontEnd.Models.Pagination>>(keyword, pagination);
                return View(receiveData);
            }
            else
            {
                var receiveData = await bookApi.RetrieveBookList<Tuple<IEnumerable<BookStoreFrontEnd.Models.Book>, BookStoreFrontEnd.Models.Pagination>>(pagination);
                return View(receiveData);
            }

        }

        // For Book Details Modal
        [Route("{bookdetails}/{isbn}")]
        [HttpGet]
        public async Task<IActionResult> BookDetails(string isbn)
        {
            var receiveData = await bookApi.GetBookDetail<BookStoreFrontEnd.Models.Book>(isbn);
            return (PartialView(receiveData));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
