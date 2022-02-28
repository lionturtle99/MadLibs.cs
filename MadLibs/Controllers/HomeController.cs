using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    [Route("/adventure")]
    public ActionResult Adventure(string noun, string nounA, string adjective, string adjectiveA, string location, string adverb)
    {
      AdventureVariable myAdventureVariable = new AdventureVariable();
      myAdventureVariable.Noun = noun;
      myAdventureVariable.NounA = nounA;
      myAdventureVariable.Adjective = adjective;
      myAdventureVariable.AdjectiveA = adjectiveA;
      myAdventureVariable.Location = location;
      myAdventureVariable.Adverb = adverb;
      return View(myAdventureVariable);
    }
    [Route("/alternate-form")]
    public ActionResult AlternateForm() { return View(); }
    [Route("/alternate")]
    public ActionResult Alternate(string verb, string thing, string place, string noun, string placeA, string ingVerb, string edVerb, string verbA)
    {
      AlternateVariable myAlternateVariable = new AlternateVariable();
      myAlternateVariable.Verb = verb;
      myAlternateVariable.Thing = thing;
      myAlternateVariable.Place = place;
      myAlternateVariable.Noun = noun;
      myAlternateVariable.PlaceA = placeA;
      myAlternateVariable.IngVerb = ingVerb;
      myAlternateVariable.EdVerb = edVerb;
      myAlternateVariable.VerbA = verbA;
      return View(myAlternateVariable);
    }
  }
}