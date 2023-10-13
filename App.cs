using System;

public class Program
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Select shape: \n 1 - Square \n 2 - Rectangle \n 3 - Triangle \n 4 - Circle");


      // Input shape
      Console.Write(">>> Select Shape: ");
      string input = Console.ReadLine();
      int select = Convert.ToInt32(input);


      // Switch for selected shape
      switch (select)
      {
         case 1:
            Console.WriteLine("Selected Square");
            break;
         case 2:
            Console.WriteLine("Selected Rectangle");
            break;
         case 3:
            Console.WriteLine("Selected Triangle");
            break;
         case 4:
            Console.WriteLine("Selected Circle");
            break;
         default:
            Console.WriteLine("Please select the correct input");
            Environment.Exit(1);
            break;
      }


      Console.WriteLine("");


      if (select == 1) // Square calculation
      {
         Console.Write(">>> Input Side Value: ");
         string value = Console.ReadLine();
         double num = Convert.ToInt32(value);

         Console.WriteLine("Square's Area: " + (num * num) + "cm^2");
         Console.WriteLine("Square's Circumference: " + (num * 4) + "cm");
      }
      else if (select == 2) // Rectangle calculation
      {
         Console.Write(">>> Input Width Value: ");
         string value = Console.ReadLine();
         double num = Convert.ToInt32(value);

         Console.Write(">>> Input Length Value: ");
         string value2 = Console.ReadLine();
         double num2 = Convert.ToInt32(value2);


         Console.WriteLine("Rectangle's Area: " + (num * num2) + "cm^2");
         Console.WriteLine("Rectangle's Circumference: " + ((num * 2) + (num2 * 2)) + "cm");
      }
      else if (select == 3) // Triangle calculation
      {
         Console.WriteLine("Select Formula: \n 1 - Area \n 2 - Circumference");
         Console.Write(">>> Select Formula: ");
         string inputT = Console.ReadLine();
         int selectT = Convert.ToInt32(inputT);

         Console.WriteLine("");

         switch (selectT) 
         {
            case 1:
               Console.Write(">>> Input Height Value: ");
               string heightValue = Console.ReadLine();
               double heightNum = Convert.ToInt32(heightValue);


               Console.Write(">>> Input Base Value: ");
               string baseValue = Console.ReadLine();
               double baseNum = Convert.ToInt32(baseValue);

               Console.WriteLine("Triangle's Area: " + ((heightNum * baseNum) * 1 / 2) + "cm^2");
               break;
            case 2:
               Console.Write(">>> Input A Value: ");
               string aValue = Console.ReadLine();
               double A = Convert.ToInt32(aValue);


               Console.Write(">>> Input B Value: ");
               string bValue = Console.ReadLine();
               double B = Convert.ToInt32(bValue);

               Console.Write(">>> Input C Value: ");
               string cValue = Console.ReadLine();
               double C = Convert.ToInt32(cValue);

               Console.WriteLine("Triangle's Circumference: " + (A + B + C) + "cm");
               break;
         }
      }
      else if (select == 4) // Circle calculation
      {
         Console.Write(">>> Input Radius Value: ");
         string value = Console.ReadLine();
         double num = Convert.ToInt32(value);

         Console.WriteLine("Circle's Area: " + "\n22/7 = " + (num * num * 22/7) + "cm^2 " + "\n3,14 = " + (num * num * 3.14) + "cm^2");
         Console.WriteLine("");
         Console.WriteLine("Circle's Circumference: " + "\n22/7 = " + (2 * 22/7 * num) + "cm " + "\n3,14 = " + (2 * 3,14 * num) + "cm");
      }
   }
}