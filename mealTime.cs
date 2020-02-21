using System;

class MealTime
{
  static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
  }

  static void Main()
  {
    AskWhatYouAteFor("breakfast");
    string yourBreakfast = Console.ReadLine();
    Console.WriteLine("You had " + yourBreakfast + " for breakfast.");

    AskWhatYouAteFor("lunch");
    string yourLunch = Console.ReadLine();
    Console.WriteLine("You had " + yourLunch + " for lunch.");

    AskWhatYouAteFor("dinner");
    string yourDinner = Console.ReadLine();
    Console.WriteLine("You had " + yourDinner + " for Dinner.");
  }
}