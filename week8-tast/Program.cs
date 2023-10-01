using System;
namespace Program
{



    class Finance{

        public static void Main(string []args){
         int many_product = 0;
         string product_name;
         string price;



         Console.Write("How many product : ");
         many_product = Int32.Parse(Console.ReadLine());

         string [][] data_product = new string [many_product][]; //เก็บตัวแปรด้านล่างไว้ในarray


         for(int i=0; i < many_product; i++)
            {
             

             Console.Write("produtc name :");  //ชื่อสินค้า
             product_name = Console.ReadLine();

             Console.Write("price :");  //ราคาสินค้า
             price = Console.ReadLine();

             Console.WriteLine("............................");




             data_product[i] = new string [] {product_name, price};



            }
            double Discount = 0.00;
            double get = 0.00;
            double vats = 0.00;
            double val = 0.00;


            Console.Write("get the money :");
            get = Int32.Parse(Console.ReadLine());

            Console.Write("tax deducted (ex.3-10) :");
            vats =Int32.Parse (Console.ReadLine());

            Console.Write("Discount (bath) :");
            Discount =Int32.Parse (Console.ReadLine());


            val = (100 + vats);

           


           //header
           Console.WriteLine();
           Console.WriteLine("             Bill             ");
           Console.WriteLine("      Welcome to CarWash24    ");
           Console.WriteLine();
           Console.WriteLine("#   product              price");
           Console.WriteLine("..............................");






           double product_price = 0.00;
           double vat = 0.00;
           double total = 0.00;
           double change = 0.00;


           for(int i=0; i < many_product; i++){
              Console.WriteLine(
                (i+1)+"   "+    
                data_product[i][0]+"                   "+
                data_product[i][1]
                );

               
                total += double.Parse(data_product[i][1]);



           }

            vat = Math.Round((total * vats) /val, 2 );
            total = (total - Discount);
            product_price = total-vat;
            change = (get - total);

            



           Console.WriteLine("..............................");
           Console.WriteLine("Product Price            "+ product_price);
           Console.WriteLine("Tax                       "+ vat);
           Console.WriteLine("Discount                  "+ Discount);
           Console.WriteLine("Total                     "+ total);
           Console.WriteLine();

           Console.WriteLine("...............................");
           Console.WriteLine("get the money             "+ get);
           Console.WriteLine("change                    "+ change);
           Console.WriteLine("                                ");
           Console.WriteLine("      *_* Thank you *_*         ");


        }
    }
}
