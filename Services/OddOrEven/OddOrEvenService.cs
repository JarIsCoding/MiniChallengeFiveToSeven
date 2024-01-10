namespace MiniChallengeFiveToSeven.Services.OddOrEven;
public class OddOrEvenService : IOddOrEvenService
{
    public string ChoseNum(string Number)
    {
        if (int.TryParse(Number, out int parsedNumber))
        {
            if (parsedNumber % 2 == 0)
            {
                return $"You chose {parsedNumber}, and that's even!";
            }
            else
            {
                return $"You chose {parsedNumber}, and that's odd!";
            }
        }
        else
        {
            return "Please only input numbers.";
        }
    }

}