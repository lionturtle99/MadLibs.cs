using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Adventure()
    {
      AdventureVariable myAdventureVariable = new AdventureVariable();
      myAdventureVariable.Noun = "North Shore Ridge";
      myAdventureVariable.NounA = "Black Mountain";
      myAdventureVariable.Adjective = "Fluthy";
      myAdventureVariable.AdjectiveA = "folopial";
      myAdventureVariable.Location = "Holy Mammoth Rock";
      return View(myAdventureVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/adventure")]
    public ActionResult Adventure(string noun, string nounA, string adjective, string adjectiveA, string location)
    {
      AdventureVariable myAdventureVariable = new AdventureVariable();
      myAdventureVariable.Noun = noun;
      myAdventureVariable.NounA = nounA;
      myAdventureVariable.Adjective = adjective;
      myAdventureVariable.AdjectiveA = adjectiveA;
      myAdventureVariable.Location = location;
      return View(myAdventureVariable);
    }
  }
}