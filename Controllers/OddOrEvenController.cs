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
    public List<int> Num = new();
    private readonly IOddOrEvenService _oddOrEvenService;

    [HttpPost]
    [Route("Number")]
    public string ChoseNum(int Number){
        return _oddOrEvenService.ChoseNum(Number);
    }
}
