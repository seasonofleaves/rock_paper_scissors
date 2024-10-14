internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors!");
    string userHand = ChooseHand();
    Console.WriteLine(userHand);
  }

  static string ChooseHand()
  {
    Console.WriteLine("Choose a Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");
    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
      return "You chose Rock 🪨";
    }
    if (userInput == "2")
    {
      return "You chose Paper 📄";
    }
    if (userInput == "3")
    {
      return "You chose Scissors✂️";
    }
    return "Pick a number";
  }
}