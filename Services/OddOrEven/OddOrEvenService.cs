namespace MiniChallengeFiveToSeven.Services.OddOrEven;
public class OddOrEvenService : IOddOrEvenService
{
    public string ChoseNum(int Number)
    {
        if (Number % 2 == 0)
        {
            return $"You chose {Number}, and thats even!";
        }
        else
        {
            return $"You chose {Number}, and thats Odd!";
        }
    }
}