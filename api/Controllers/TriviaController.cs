using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using api.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class TriviaController : Controller
    {
        private const string type = "?json";
        private const string endpoint = "http://numbersapi.com/";

        // GET api/trivia/number
        [HttpGet("{number}")]
        public async Task<TriviaResponse> GetAsync(int number)
        {
            //call numbersapi.com and return results
            var httpClient = new HttpClient();
            var response =await httpClient.GetAsync(requestUri: endpoint + number+ type);
            var triviaResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TriviaResponse>(triviaResult);
        }

       
    }
}
