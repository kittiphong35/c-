using System;
namespace Program
{


    class Movie
    {

        public string movie_Name { get; set; }
        public string movie_round { get; set; }

        public void chack_state(string choice)
        {
            Movie mv = new Movie();
            


            if (choice == "q")
            {
                Console.WriteLine("Exit Program");

            }
            else if (choice == "1"|| choice == "2"|| choice == "3")
            {
                

                //step 2
                mv.RoundTimes();
                

            }
            else
            {
               
                Console.WriteLine("Please Try Again Here.......");
                mv.Menu();
            }

        }
        public void ChackRoundTimes(string round){
            Movie mv = new Movie();

            if(round == "q")
            {
                Console.WriteLine("Exit Program");
            }
            else if(round == "1"|| round == "2"|| round == "3")
            {
                mv.Finish();
            }
            else if(round == "h")
            {
                Console.WriteLine("go to main ");
                mv.Menu();
            }
            else
            {
                Console.WriteLine("Please Try Again Here.......");
                mv.RoundTimes();
            }
        }


        public void Finish()
        {
            
            Console.WriteLine("*************************");
            Console.WriteLine("You Booking Success");
            string movie_Name ="";
            string movie_round = "";

           



        }
        public void RoundTimes()
        {
            Movie mv = new Movie();
            Console.WriteLine("Please Selected Times");
            Console.WriteLine("1 10.00 - 12.00");
            Console.WriteLine("2 12.00 - 14.00");
            Console.WriteLine("3 14.00 - 16.00");
            Console.WriteLine("Press q = exit, h = main");
            Console.WriteLine("........................");
           
           
                       
            // Chack เวลารอบหนัง
            string round;
            round = Console.ReadLine();
            mv.ChackRoundTimes(round);


        }

        public void Menu()
        {
            string  choice;
            Console.WriteLine("Welcome to Kitti Cineplex");
            Console.WriteLine("Please Selected Movie");
            Console.WriteLine("1.Sapalur");
            Console.WriteLine("2.The Marvel");
            Console.WriteLine("3.TeeYod");
            Console.WriteLine("Press q = exit");
            Console.WriteLine("......................");
           
          
            

            choice = Console.ReadLine();

            movie_Name = choice;

            Movie mv = new Movie();
            mv.chack_state(choice);

        }



        public static void Main(string[] args)
        {

            Movie mv = new Movie();

            //Step 1 เลือกชื่อหนัง
            mv.Menu();


        }
    }
    
   





}