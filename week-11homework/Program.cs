using System;
     
public class Program
{
 public static void Main()
 {
  Console.WriteLine("Welcome to Kitti Cineplex");
  Console.WriteLine("Please Seleted Movie");
  Console.WriteLine("1.Sappalur");
  Console.WriteLine("2.The Marvel");
  Console.WriteLine("3.TeeYod");
  Console.WriteLine("press q = exit");
  Console.WriteLine("......................");
  
  char movieSelection = Console.ReadKey().KeyChar;
  
  if(movieSelection == 'q')
  {
   return;
  }
  else
  {
   Console.WriteLine();
   Console.WriteLine("Please Selected Times");
   Console.WriteLine("1.10.80-12.00");
   Console.WriteLine("2.12.80-14.00");
   Console.WriteLine("3.14.00-16.00");
   Console.WriteLine("press q=exit, h=main");
   Console.WriteLine("......................");
   
   
   char timeSelection = Console.ReadKey().KeyChar;
   
   if(timeSelection == 'q')
   {
    return;
   }
   else if(timeSelection == 'h')
   {
    Main();
   }
   else
   {
    Console.WriteLine();
    Console.WriteLine("**********************");
    Console.WriteLine("You Booking Success");
    string movie = "";
    switch(movieSelection)
    {
     case '1':
      movie = "Sappalur";
      break;
     case '2':
      movie = "The Marvel";
      break;
     case '3':
      movie = "TeeYod";
      break;
     default:
      break;
    }
    string time = "";
    switch(timeSelection)
    {
     case '1':
      time = "10.80-12.00";
      break;
     case '2':
      time = "12.80-14.00";
      break;
     case '3':
      time = "14.00-16.00";
      break;
     default:
      break;
    }
    Console.WriteLine($"{movie}@{time}");
    Console.WriteLine("Welcome to Kitti Cineplex");
   }
  }
 }
}
