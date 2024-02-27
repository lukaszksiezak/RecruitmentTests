using Microsoft.Extensions.DependencyInjection;
using Recruitment.Diamond;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0 || args[0].Length != 1)
        {
            Console.WriteLine("Please provide a single character as a command line argument.");
            return;
        }

        char inputChar = args[0][0];

        if (char.IsLetter(inputChar))
        {
            var service = Startup.GetServices().BuildServiceProvider();
            var diamondService = service.GetService<DiamondService>();
            diamondService!.GenerateDiamond(inputChar);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}