using System;

class AlwaysOne
{
  static void Main()
  {
    Console.WriteLine("Give me two numbers");
    string numberOne = Console.ReadLine();
    string numberTwo = Console.ReadLine();

    Console.WriteLine("I will add those two numbers");

    int yourFirstNumber = int.Parse(numberOne);
    int yourSecondNumber = int.Parse(numberTwo);

    int combinedNumber = yourFirstNumber + yourSecondNumber;

    string yourCombinedNumber = combinedNumber.ToString();

    Console.WriteLine("here it is: " + yourCombinedNumber);

    Console.WriteLine("Give me two numbers");
    string numberOnex = Console.ReadLine();
    string numberTwox = Console.ReadLine();

    Console.WriteLine("I will multiply those two numbers");

    int yourFirstNumberx = int.Parse(numberOnex);
    int yourSecondNumberx = int.Parse(numberTwox);

    int combinedNumberx = yourFirstNumberx * yourSecondNumberx;

    string yourCombinedNumberx = combinedNumberx.ToString();

    Console.WriteLine("here it is: " + yourCombinedNumberx);

  }
}
// Console.WriteLine("Give me any number.");
// Console.WriteLine("I will magically turn that number into 1!");
// string stringNumber = Console.ReadLine();
//
// int yourNumber = int.Parse(stringNumber);
// int theNumberOne = yourNumber / yourNumber;
//
// string stringNumberOne = theNumberOne.ToString();
//
// Console.WriteLine("Here it is: " + stringNumberOne);
