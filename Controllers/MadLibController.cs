using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.MadLib;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("Controller")]
public class MadLibController : Controller
{
    private readonly IMadLibService _madLibService;
    public MadLibController(IMadLibService madLibService){
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("Madlib/{Object}/{Verb}/{Adj}/{Place}/{Person}")]
    public string MadLib(string Object, string Verb, string Adj, string Place, string Person)
    {
        return _madLibService.MadLib(Object, Verb, Adj, Place, Person);
    }
}