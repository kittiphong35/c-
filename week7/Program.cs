using System;
namespace Program
{



    class Finance{

        public static void Main(string []args){
            int number_product = 0; //จำนวนชิ้นสินค้า
            string code;
            string product_name;
            string price;
            
            // step 1 จำนวนสินค้า
            Console.Write("number of product : "); //บอก loop
            number_product = Int32.Parse(Console.ReadLine()); // แปลงจาก stringf to int

            string [][] data_product = new string [number_product][]; // 3ตัวแปรด้านล่างจะเก็บไว้ใน array

            // step 2 เก็บข้อมูลสินค้า
           for(int i=0; i < number_product; i++)
            {
                
                Console.Write("code product : "); // รหัสสินค้า
                code = Console.ReadLine();
               
                Console.Write("product name : "); //ชื่อสินค้า
                product_name = Console.ReadLine();
               
                Console.Write("price : "); //ราคา สินค้า
                price = Console.ReadLine();

                Console.WriteLine("..............................");



                data_product[i] = new string[] {code, product_name, price };

                




                

            }


           // step 1
           //header
           Console.WriteLine("Mr.kittiphong Chaimon");
           Console.WriteLine("..............................");
           Console.WriteLine("# title (code)           price");
           Console.WriteLine("..............................");

           //varible
           double product_price = 0.00;
           double vat = 0.00;
           double val = 107; //สูตรหา vat 7%
           double total = 0.00;

           //step 2

           for(int i=0; i < number_product; i++){
                Console.WriteLine(
                (i+1)+" "+    
                data_product[i][1]+"   "+
                data_product[i][0]+"              "+
                data_product[i][2]+"   "
                );

                // ราคาสินค้าแต่ละรายการ
                total += double.Parse(data_product[i][2]);
            }

            vat = (total*7)/val;
            vat = Math.Round(vat, 2);
            total = total;
            product_price = total-vat;

           
           // step 3
           //footer
           Console.WriteLine("..............................");
           Console.WriteLine("Product Price          "+product_price);
           Console.WriteLine("Vat                    "+ vat);
           Console.WriteLine("Total                  "+total);
           Console.WriteLine();
           Console.WriteLine("      *_* Thank you *_*         ");

             

         /*for(int i=0; i < number_product; i++){
                    Console.WriteLine(data_product[i][0]);
                }*/

            
        }
    }

    
}

               