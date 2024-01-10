namespace MiniChallengeFiveToSeven.Services.NumReverse;
public class NumReverseService : INumReverseService
{
    public string NumReverse(int Numbers)
    {
        string spaghetti = Numbers.ToString();
        string result = "";

        for (int i = spaghetti.Length - 1; i >= 0; i--)
        {
            result += spaghetti[i];
        }
        return $"Your numbers were {Numbers} and here they are reversed! {result}";
    }
}
