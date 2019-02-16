using BookStoreFrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStoreFrontEnd.Helper
{
    public class BookAPI
    {
        HttpClient httpClient;

        public BookAPI()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44390/");
        }

        // Helper for api/books/retrieve/{pagesize}/{pageno}
        public async Task<T> RetrieveBookList<T>(Pagination pagination)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync("api/books/retrieve/" + pagination.PageSize + '/' + pagination.PageNo);
            T retrieveData = default(T);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                retrieveData = JsonConvert.DeserializeObject<T>(result);
            }

            return (retrieveData);
        }

        // Helper for api/books/search/{keyword}/{pagesize}/{pageno}
        public async Task<T> SearchBook<T>(string keyword, Pagination pagination)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync("api/books/search/" + Uri.EscapeDataString(keyword) + "/" + pagination.PageSize + '/' + pagination.PageNo);
            T retrieveData = default(T);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                retrieveData = JsonConvert.DeserializeObject<T>(result);
            }

            return (retrieveData);
        }

        // Helper for api/books/retrieve/{isbn}
        public async Task<T> GetBookDetail<T>(string isbn)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync("api/books/retrieve/" + Uri.EscapeDataString(isbn));
            T retrieveData = default(T);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                retrieveData = JsonConvert.DeserializeObject<T>(result);
            }

            return (retrieveData);
        }
    }
}
