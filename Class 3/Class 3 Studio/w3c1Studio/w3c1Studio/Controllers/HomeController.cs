using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using w3c1Studio.Models;

namespace w3c1Studio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html =
                "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                    "<option value='English' selected> English</option>" +
                    "<option value='French'>French</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name="World", string language="English")
        {
            string greeting = CreateMessage(name, language);
            return Content(greeting, "text/html");
        }

        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        
        public static string CreateMessage(string name, string language)
        {
            string translation = "";
            switch(language)
            {
                case "French":
                    translation = "Bonjour";
                    break;
                default:
                    translation = "Hello";
                    break;
                
            }
            return string.Format("{0}, {1}", translation, name);
        }
    }
}
