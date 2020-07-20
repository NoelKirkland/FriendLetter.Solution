using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hellofriend")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend.";  }

    [Route("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}