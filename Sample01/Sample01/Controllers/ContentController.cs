using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        private readonly List<Content> contents;
        public ContentController(IOptions<List<Content>> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            //var contents = new List<Content>();

            //for (int i = 0; i < 12; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now });
            //}
            return View(new ContentViewModel { Contents = contents });

            //return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}