using System;
using RiddlesOfTheSphinx;

class Program
{
  public static Sphinx sphinx = new Sphinx();
  static void Main()
  {
    Console.WriteLine("Ready to solve some riddles? Defeat the sphinx by answering a riddle correctly");
    var riddle = sphinx.ReturnARandomRiddle();
    Console.WriteLine(riddle.Question);
    string answer = Console.ReadLine();
    if(answer == riddle.Answer) {
      Console.WriteLine("That's correct! *Sphinx explodes*");
      Console.WriteLine("Would you like to play another round? ['yes' for yes, 'Enter' for no");
      string answerToContinuing = Console.ReadLine();
      if(answerToContinuing == "yes") {
        Main();
      }
    } else {
      Console.WriteLine("That's incorrect. The answer is " + riddle.Answer);
      Console.WriteLine("Would you like to play another round? ['yes' for yes, 'Enter' for no");
      string answerToContinuing = Console.ReadLine();
      if(answerToContinuing == "yes") {
        Main();
      }
    }
  }
}