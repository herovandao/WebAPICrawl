using Microsoft.AspNetCore.Mvc;
using CrawlApi.Common;
using Newtonsoft.Json;

namespace CrawlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CrawlController : ControllerBase
    {
        [HttpGet]
        public void GetTodoItems()
        {
            System.Console.WriteLine("Get done!");
            SearchBot search = new SearchBot();
            search.GetHtml();
        }

        [HttpPost]
        // https://docs.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api
        public async Task CreateRequest([FromBody] string jsonObject)
        {
            // string jsonObject
            System.Console.WriteLine("Vào Post");
            await Task.Run(()=>
            {
                System.Console.WriteLine(jsonObject);
                // var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonObject)!;
                // System.Console.WriteLine(dynamicObject["resoucre"]);
                // System.Console.WriteLine(dynamicObject["xpath1"]);
            });
        }
        [HttpPut("{id}")]
        public async Task PutTest(int id)
        {
            System.Console.WriteLine("Put Test");
            await Task.Run(()=>
            {
                System.Console.WriteLine(id);
                // var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonObject)!;
                // System.Console.WriteLine(dynamicObject["resoucre"]);
                // System.Console.WriteLine(dynamicObject["xpath1"]);
            });
        }
    }
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

