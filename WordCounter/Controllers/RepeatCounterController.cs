using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {
        [HttpGet("/repeatcounter")]
        public ActionResult Index(string sentence, string word)
        {
            RepeatCounter repeatCounter = new RepeatCounter(sentence, word);
            return View(repeatCounter);
        }
        [HttpGet("/repeatcounter/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/repeatcounter")]
        public ActionResult FindMatches(string sentence, string word)
        {
        

        }
    }
}