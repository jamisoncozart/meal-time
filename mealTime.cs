using System;

class MealTime
{
  static void Main()
  {
    AskAndSayWhatYouAteFor("breakfast");
    AskAndSayWhatYouAteFor("lunch");
    AskAndSayWhatYouAteFor("dinner");    
  }

  static void AskAndSayWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("You had " + yourMeal + " for " + meal + ".");
  }
}