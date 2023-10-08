using System;
namespace Program{



  class CoffeeLuxer
  {

  }

  class CoffeePremuim
  {
    public int val;

     public static void Main(string[] args){

        int val;

     CoffeePremuim CP = new CoffeePremuim();
     CP.selected_band(); //Display band
     val =Int32.Parse(Console.ReadLine());
     CP.Lines();
     CP.Routes(val);


     //เลือก Manu in Band Coffee


    }

   

    public void Routes(int val)
    {
        CoffeePremuim CP = new CoffeePremuim();

        switch(val)
        {
            case 1:
             CP.amezon();
             break;
            
            case 2:
             CP.inthanin();
             break;
            
            case 3:
             CP.punthai();
             break;
            
            case 4:
             CP.doro();
             break;
            default:
             break;
        }

    }
    
    public void Lines()
    {
        Console.WriteLine("...........................");
    }
    
    public void selected_band()
    {
     

     Console.WriteLine("Plese selected band coffee ");
     Console.WriteLine("1 : Amezon ");
     Console.WriteLine("2 : Inthanin ");
     Console.WriteLine("3 : Punthai ");
     Console.WriteLine("4 : D-Oro ");

     Console.Write("Selected : ");
     val = Int32.Parse(Console.ReadLine());
     Console.WriteLine("..............................");
    }
    
    public void amezon(){
        Console.WriteLine("  Amezon cafe   ");
        Console.WriteLine("     Manu       ");
        Console.WriteLine("  Black Coffee  ");
        Console.WriteLine("  Capu Chino    ");
        Console.WriteLine("  Late          ");
    }
    public void inthanin(){
        Console.WriteLine("  Inthanin cafe   ");
        Console.WriteLine("      Manu        ");
        Console.WriteLine("  Black Mix Orange");
        Console.WriteLine("  Late ");
        Console.WriteLine("  Capu Chino ");
    }
  
    public void punthai(){
        Console.WriteLine("  Punthai cafe  ");
        Console.WriteLine("      Manu      ");
        Console.WriteLine("  Chocolate     ");
        Console.WriteLine("  Americano     ");
    }
    public void doro(){
        Console.WriteLine("  doro cafe     ");
        Console.WriteLine("     Manu       ");
        Console.WriteLine("  Milk Chocolate");
        Console.WriteLine("  Capu Chino    ");
        
    }
  




  }
}
