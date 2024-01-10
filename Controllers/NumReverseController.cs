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

    [HttpPost]
    [Route("Input Here")]
    public string NumReverse(int Numbers)
    {
        return _numReverseService.NumReverse(Numbers);
    }

}
