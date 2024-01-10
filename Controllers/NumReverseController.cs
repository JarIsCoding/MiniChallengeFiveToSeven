using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.NumReverse;

namespace MiniChallengeFiveToSeven.Controllers;
[ApiController]
[Route("NumberReverse")]
public class NumReverseController
{
    private readonly INumReverseService _numReverseService;

    public NumReverseController(INumReverseService numReverseService){
        _numReverseService = numReverseService;
    }

    [HttpGet]
    [Route("InputHere/{Numbers}")]
    public string NumReverse(string Numbers)
    {
        return _numReverseService.NumReverse(Numbers);
    }

}
