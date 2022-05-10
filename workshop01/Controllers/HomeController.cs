using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace workshop01.Controllers
{
    public class HomeController : Controller
    {
        string[] arryMessages = { "Logic will get you from A to B.Imagination will take you everywhere.",
"There are 10 kinds of people.Those who know binary and those who don't.",
"There are two ways of constructing a software design.One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.",
"It's not that I'm so smart, it's just that I stay with problems longer.",
"It is pitch dark. You are likely to be eaten by a grue."};

        public ActionResult Index()
        {
            ViewBag.Index = GetRandomMessageIndex();
            ViewBag.Message = arryMessages[ViewBag.Index];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private int GetRandomMessageIndex()
        {
            return new Random().Next(arryMessages.Length);
        }
    }
}