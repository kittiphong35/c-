using System;
namespace Program{



  class CoffeeLuxer
  { }

  class CoffeePremuim
  {
     public static void Main(string[] args){  //จุดเริ่มต้นเหมือนประตูทางเข้า

        int val;

     CoffeePremuim CP = new CoffeePremuim();//เปลี่ยนตัวแปรเป็นตันย่อ
     CP.selected_band(); //Display band
     val =Int32.Parse(Console.ReadLine());
     CP.Line();
     CP.Routes(val);
     CP.Line();


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
    
    public void Line()
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
