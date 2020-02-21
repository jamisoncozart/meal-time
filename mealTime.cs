using System;

class MealTime
{
  static void Main()
  {
    Console.WriteLine("What did you eat for breakfast?");
    string yourBreakfast = Console.ReadLine();
    Console.WriteLine("You had " + yourBreakfast + " for breakfast.");
  }
}