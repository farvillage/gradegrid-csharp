using System;

class Program 
{
  public static void Main (string[] args)
  {
    int grade = 0;

    //GRADE 1:
    Console.WriteLine("Input your first grade: ");
    Console.ReadLine();

    //GRADE 2:
    Console.WriteLine("Input your second grade: ");
    Console.ReadLine();

    //GRADE 3:
    Console.WriteLine("Input your third grade: ");
    Console.ReadLine();

    if ((2 * grade) + (3 * grade) + (5 * grade) / 2 + 3 + 5 >= 7)
    {
      Console.WriteLine("You're approved!");
    }
    else
    {
      Console.WriteLine("You didn't make it.");
    }
  }
}
