namespace MiniChallengeFiveToSeven.Services.NumReverse;
public class NumReverseService : INumReverseService
{
    public string NumReverse(string Numbers)
    {
        if (int.TryParse(Numbers, out int parsedNumber))
        {
            string result = "";

            for (int i = Numbers.Length - 1; i >= 0; i--)
            {
                result += Numbers[i];
            }

            return $"Your numbers were {parsedNumber} and here they are reversed! {result}";
        }
        else
        {
            return "Please enter only numbers";
        }
    }

}
