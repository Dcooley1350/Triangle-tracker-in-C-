using System;

class Triangle
{
    public int SideOne;
    public int SideTwo;
    public int SideThree;

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;
    }
    public void CheckTriangle()
    {
        if (SideOne + SideTwo < SideThree) 
        {
            Console.WriteLine("ThIS NO TRIANGLE.");
        }
        else if (SideTwo + SideThree < SideOne) 
        {
            Console.WriteLine("ThIS NO TRIANGLE.");
        }
        else if (SideOne + SideThree < SideTwo)
        {
            Console.WriteLine("ThIS NO TRIANGLE.");
        }
        else
        {
            if ((SideOne == SideTwo) && (SideOne == SideThree))
            {
                Console.WriteLine("This is an Equillateral Triangle!");
            }
            else if (SideOne == SideTwo || SideTwo == SideThree || SideTwo == SideThree )
            {
                Console.WriteLine("This is an Isosceles Triangle!");
            }
            else if ((SideOne != SideTwo) && ( SideOne != SideThree) && (SideTwo != SideThree))
            {
                Console.WriteLine("You got yourself a Scalene Triangle!");
            }

        }
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a length for the first side of your triangle.");
        string sideOne = Console.ReadLine();
        int sideOneInt = int.Parse(sideOne);
        Console.WriteLine("Please enter a length for the second side of your triangle.");
        string sideTwo = Console.ReadLine();
        int sideTwoInt = int.Parse(sideTwo);
        Console.WriteLine("Please enter a length for the third side of your triangle.");
        string sideThree = Console.ReadLine();
        int sideThreeInt = int.Parse(sideThree);
        Triangle myTriangle = new Triangle (sideOneInt, sideTwoInt, sideThreeInt);
        myTriangle.CheckTriangle();
    }

}
