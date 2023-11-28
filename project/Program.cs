using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"1", 80.0},
            {"2", 80.0},
            {"3", 95.0},
            {"4", 100.0},
            {"5", 90.0},
            {"6", 50.0},
            {"7", 550.0},
            {"8", 590.0},
            {"9", 350.0},
            {"10", 56.0},
            {"11", 75.0},
            {"12", 230.0},
            {"13", 56.0},
            {"14", 70.0},
            {"15", 130.0},
            {"16", 60.0}
        };
        Dictionary<int, int> moneyDenominations = new Dictionary<int, int>
        {
            {1000, 1000},
            {500, 500},
            {100, 100},
            {50, 50},
            {20, 20},
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.WriteLine("-------  WELCOME TO ------- ");

        while (true)
        {
            Console.WriteLine("--------------- KITTI PHARMACY --------------- ");
            Console.WriteLine("------------ Please Selected Remedy -----------");
            Console.WriteLine();

                Console.WriteLine("---------------  Tablet ----------------- ");
                Console.WriteLine("***** 1.Amoxicillin - 100 Tablets - 80 Bath *****");
                Console.WriteLine("***** 2.Steroids - 50 Tablets - 80 Bath *****");
                Console.WriteLine("***** 3.Paracetamol - 100 Tablets - 95 Bath *****");
                Console.WriteLine("***** 4.Lbuprofen - 50 Tablets - 100 Bath *****");
                Console.WriteLine("***** 5.Aspirin - 50 Tablets - 90 Bath *****");
                Console.WriteLine("***** 6.Antihistamine - 20 Tablets - 50Bath *****");
                Console.WriteLine();
                Console.WriteLine("--------------- Softgel ------------------");
                Console.WriteLine("***** 7.AMWAY - 60 Tablets - 550 Bath *****");
                Console.WriteLine("***** 8.BLACKMORES - 60 Tablets - 590 Bath *****");
                Console.WriteLine("***** 9.DR.PONG - 60 Tablets - 359 Bath *****");
                Console.WriteLine();
                Console.WriteLine("--------------- Potion -------------------");
                Console.WriteLine("**** 10. Cough Medicine - 1 Bottle - 56 Bath ****");
                Console.WriteLine("**** 11.Antacil Gel - 1 Bottle - 75 Bath ****");
                Console.WriteLine("**** 12.Gaviscon - 1 Bottle - 230 Bath ****");
                Console.WriteLine();
                Console.WriteLine("--------------- Lotion -------------------");
                Console.WriteLine("**** 13.Calamine - 1 Box - 56 Bath ******");
                Console.WriteLine("**** 14.Zema - 1 Box - 70 Bath ******");
                Console.WriteLine("**** 15.Counterpain - 1 Box - 130 Bath *****");
                Console.WriteLine("**** 16.Himalaya Althea - 1 Box - 60 Bath *****");
                


            

            Console.Write("Please Selected Products (Check out  'c'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "c")
            {
                break;
            }

            if (products.ContainsKey(input))
            {
                selectedProducts.Add(input);
                totalPrice += products[input];
                Console.WriteLine($"{input} Add ");
            }
            else
            {
                Console.WriteLine("Please Select Again");
            }
        }

        Console.WriteLine($"Price: {totalPrice} Bath");

        double payment = 0.0;
        while (payment < totalPrice)
        {
            Console.Write("Please Confirm The Amount (1000, 500, 100, 50, 20):");
            int.TryParse(Console.ReadLine(), out int paymentDenomination);

            if (moneyDenominations.ContainsKey(paymentDenomination))
            {
                moneyDenominations[paymentDenomination]++;
                payment += paymentDenomination;
            }
            else
            {
                Console.WriteLine("Please Go To The Checkout");
            }
        }


        double change = payment - totalPrice;
        Console.WriteLine($"Change: {change} Bath");
        Console.WriteLine("\n         *_* Thank you *_* !          ");
    }
}