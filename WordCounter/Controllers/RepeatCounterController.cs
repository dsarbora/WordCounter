using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {
        [HttpGet("/repeatcounter")]
        public ActionResult Index()
        {
            var model = RepeatCounter.Find();
            
            return View(model);
        }
        [HttpGet("/repeatcounter/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/repeatcounter")]
        public ActionResult Create(string sentence, string word)
        {
            RepeatCounter repeatCounter = new RepeatCounter(sentence, word);
            string[] sentArr = repeatCounter.GetSentenceArray();
            repeatCounter.CheckArray(sentArr);
            
            return RedirectToAction("Index", repeatCounter);
        }
    }
}