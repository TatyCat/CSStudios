using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class3StudioApplication.Models;

namespace Class3StudioApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html =
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<style>" +
                "body{background-color: blue;}" +
                "form{text-align: center;}"+
                "h1{color: white; text-align: center; font size='26'}"+
                "</style>" + 
                "</head>" +
                    "<body>" +
                    "<h1>Welcome! Enter your name:</h1>"+
                     "<form method='post' action='/Hello'>" +
                     "<input type='text' name='name'/>" +
                     "<select name='language'>" +
                         "<option value='English' selected> English</option>" +
                         "<option value='French'>French</option>" +
                          "<option value='German'>German</option>" +
                          "<option value='Italian'>Italian</option>" +
                          "<option value='Hindi'>Hindi</option>" +
                          "<option value='Russian'>Russian</option>" +
                     "</select>" +
                     "<input type='submit' value='Greet me!'/>" +
                    "</form>" +
                 "</body>" +
                 "</html>";
            return Content(html, "text/html");
        }
        
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "English")
        {
            string greeting = CreateMessage(name, language);
            string displayPgHtml = 
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<style>" +
                "body{background-color: blue; text-align: center;}" +
                "h1{color: white; text-align: center; font size='40'}" +
                "</style>" +
                "</head>" +
                    "<body>" +
                    "<h1>"+ $"{greeting}" + "</h1>" +
                 "</body>" +
                 "</html>";

            return Content(displayPgHtml, "text/html");
        }


        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string translation = "";
            switch (language)
            {
                case "French":
                    translation = "Bonjour";
                    break;
                case "German":
                    translation = "Hallo";
                    break;
                case "Italian":
                    translation = "Ciao";
                    break;
                case "Hindi":
                    translation = "Namaste";
                    break;
                case "Russian":
                    translation = "ZDRAS - TVUY - TE";
                    break;
                default:
                    translation = "Hello";
                    break;

            }
            return string.Format("{0}, {1}", translation, name);
        }
    
    }
}
