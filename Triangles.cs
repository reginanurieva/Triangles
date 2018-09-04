using System;
using System.Collections.Generic;

class Triangle
{
  private int Side1;
  private int Side2;
  private int Side3;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public int getSide1()
  {
    return Side1;
  }

  public int getSide2()
  {
    return Side2;
  }

  public int getSide3()
  {
    return Side3;
  }

  public bool validateTriangle()
  {
    int maxVal = Math.Max(Side1, Math.Max(Side2, Side3));
    int sumOfTwoSides = Side1+Side2+Side3-maxVal;
    if (maxVal > sumOfTwoSides)
    {
      return false;
    }
    //maxVal <= sumOfTwoSides
    else
    {
      return true;
    }
  }

  public bool validateEquilateral()
  {
    if(Side1 == Side2 && Side2 == Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool validateIsosceles()
  {
    if(Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool validateScalene()
  {
    if(Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a side 1 of Triangle: ");
    int userSide1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter a side 2 of Triangle: ");
    int userSide2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter a side 3 of Triangle: ");
    int userSide3 = int.Parse(Console.ReadLine());

    Triangle triangle = new Triangle(userSide1, userSide2, userSide3);
    if (triangle.validateTriangle() == false)
    {
      Console.WriteLine("Not a triangle");
    }
    else
    {
      if (triangle.validateEquilateral() == true)
      {
        Console.WriteLine("You've got the Equilateral!");
      }
      else if (triangle.validateIsosceles()== true)
      {
        Console.WriteLine("You've got an Isosceles!");
      }
      else if(triangle.validateScalene()==true)
      {
        Console.WriteLine("You've got a Scalene!");
      }
    }

  }
}
