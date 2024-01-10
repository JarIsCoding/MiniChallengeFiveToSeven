
namespace MiniChallengeFiveToSeven.Services.MadLib;

public class MadLibService : IMadLibService
{
    public List<string> words = new();
    public string MadLib(string Object, string Verb, string Adj, string Place, string Person)
    {
        words.Add(Object);

        words.Add(Verb);

        words.Add(Adj);

        words.Add(Place);

        words.Add(Person);

        return $"Waking up, {Person} sees themself at {Place}. Confused, {Person} {Verb}s out of {Place}. Evenutally as {Person} gets far enough they turn around and see {Object} fall on {Place} as it proceeds to {Adj}ly EXPLODE.";
    }
}
