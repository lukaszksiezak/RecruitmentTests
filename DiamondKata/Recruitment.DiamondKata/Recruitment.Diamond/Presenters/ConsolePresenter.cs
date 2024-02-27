namespace Recruitment.Diamond.Presenters
{
    public class ConsolePresenter : IPresenter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
