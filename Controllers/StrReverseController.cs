using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.StrReverse;

namespace MiniChallengeFiveToSeven.Controllers;
[ApiController]
[Route("StringReverse")]
public class StrReverseController
{
    public StrReverseController(IStrReverseService StrReverseService){
        _strReverseService = StrReverseService;
    }
    public List<string> reverse = new();
    private readonly IStrReverseService _strReverseService;

    [HttpGet]
    [Route("InputHere/{revstring}")]
    public string Reversed(string revstring)
    {
        return _strReverseService.Reversed(revstring);
    }
}
