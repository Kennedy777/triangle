using System;

public class Triangle
{
   public static void Main()
  {
    Console.WriteLine("Enter a positive integer:");
     string sideOne = Console.ReadLine();
     int sideone = int.Parse(sideOne);

     Console.WriteLine("Enter another number:");
      string sideTwo = Console.ReadLine();
      int sidetwo = int.Parse(sideTwo);

      Console.WriteLine("Enter another number:");
       string sideThree= Console.ReadLine();
       int sidethree = int.Parse(sideThree);


   if ((sideone + sidetwo<sidethree)|| (sideone + sidethree<sidetwo) || (sidetwo+sidethree < sideone))
    {
    Console.WriteLine("Not a triangle");
     }
     else if ((sideone==sidetwo)&&(sidetwo==sidethree))
     {
     Console.WriteLine("Equilateral");
      }
    else if ((sideone==sidetwo)||(sidetwo==sidethree)||(sidetwo==sidethree))
     {
     Console.WriteLine("Isoseles");
     }
     else
     {
     Console.WriteLine("Scalene");
     }

   }

}
