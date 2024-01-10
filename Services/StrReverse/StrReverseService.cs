using System.Text;

namespace MiniChallengeFiveToSeven.Services.StrReverse;
public class StrReverseService : IStrReverseService
{
    public string Reversed(string revstring)
    {
        int revlength = revstring.Length -1;
        string result = "";
        for (int i = revlength; i >= 0; i--){
            result += revstring[i];
        }
        return $"Your word is {revstring}, and here it is backwards! {result}";

        


            //        Console.WriteLine("Enter a string");
            // string userInput = Console.ReadLine();
            // int indexStr = userInput.Length - 1;
            
            // for (int i = indexStr; i >= 0; i--)
            //     Console.Write(userInput[i]);
            // correctInput = false;
    }
}