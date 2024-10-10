
namespace RPS
{
    public class Result
    {
        public void DetermineOutput(string userChoice, string computerChoice)
        {
            switch (userChoice + computerChoice)
            {
                case "rs":
                case "sp":
                case "pr":
                    Console.WriteLine("You won!");
                    break;
                case "rp":
                case "sr":
                case "ps":
                    Console.WriteLine("You lost!");
                    break;
                case "rr":
                case "pp":
                case "ss":
                    Console.WriteLine("It's a draw");
                    break;
            }
        }
    }
}