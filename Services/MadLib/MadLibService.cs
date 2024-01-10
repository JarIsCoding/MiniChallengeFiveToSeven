
namespace MiniChallengeFiveToSeven.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string MadLib(string Object, string Verb, string Adj, string Place, string Person)
    {
        return $"Waking up, {Person} sees themself at {Place}. Confused, {Person} {Verb}s out of {Place}. Evenutally as {Person} gets far enough they turn around and see {Object} fall on {Place} as it proceeds to {Adj}ly EXPLODE.";
    }
}
