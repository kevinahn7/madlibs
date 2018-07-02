using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        { 
            return View(); 
        }

        [Route("/result")]
        public ActionResult Result()
        {
            WordVariables myWordVariable = new WordVariables();
            myWordVariable.SetName(Request.Query["name"]);
            myWordVariable.SetAdjOne(Request.Query["adjOne"]);
            myWordVariable.SetVerbOne(Request.Query["verbOne"]);

            myWordVariable.SetNounOne(Request.Query["nounOne"]);
            myWordVariable.SetVerbTwo(Request.Query["verbTwo"]);
            myWordVariable.SetNounTwo(Request.Query["nounTwo"]);

            myWordVariable.SetVerbThree(Request.Query["verbThree"]);
            myWordVariable.SetNounThree(Request.Query["nounThree"]);
            myWordVariable.SetAdverb(Request.Query["adverb"]);

            return View(myWordVariable);
        }

    }
}