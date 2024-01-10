using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.OddOrEven;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("OddOrEven")]
public class OddOrEvenController : Controller
{
    public OddOrEvenController(IOddOrEvenService oddOrEvenService){
        _oddOrEvenService = oddOrEvenService;
    }
    private readonly IOddOrEvenService _oddOrEvenService;

    [HttpGet]
    [Route("Number/{Number}")]
    public string ChoseNum(string Number){
        return _oddOrEvenService.ChoseNum(Number);
    }
}
