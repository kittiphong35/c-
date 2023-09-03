/* plus
int plus1 = 2;
int plus2 = 3;
int total;

total = plus1 + plus2;

Console.Write(total); */



/* minus 
int minus1 = 4;
int minus2 = 2;
int total = minus1 - minus2;

Console.Write(total); */



/* modulus 
int modul1 = 10;
int modul2 = 5;
int total = modul1 % modul2;

Console.Write(total);*/



/* ++บวกขี้นทีล่่ะหนี่ง
int plus = 0;
int total = 0;

plus++;
total = plus;

Console.Write(plus++);*/



/* -- ลดลงที่ละหนึ่ง
int minus_down = 10;
int total = 0;


minus_down--;
total = minus_down;

Console.Write(total);*/


/* min/max
int min = Math.Min(4,4);

Console.WriteLine(min);



int Max = Math.Max(4,10);

Console.Write(Max);*/



/* string
string Hello = "Hello";
string World = "World";

Console.WriteLine(Hello+" "+World);*/


/*  bool
bool Val = false;
bool Check = false;

Console.WriteLine(Val==Check);*/


 /* if else
int input;

Console.Write("input value : ");
input = Int32.Parse(Console.ReadLine());




if(input == 2){
    Console.WriteLine("true success");
}
else if (input== 3){
    Console.WriteLine("Yes this is 3 value success");
}

else if (input== 4){
    Console.WriteLine("Yes this is 4 value success");
}

else if (input== 5){
    Console.WriteLine("Yes this is 5 value success");
}

else if (input== 6 || input ==12){
    Console.WriteLine("Yes this is 6 or 12 value success");
}

else{
    Console.WriteLine("false Value Check");
} 
*/



/* case
int day = 8;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
    default:
    Console.WriteLine("Not Found");
    break;
}*/
// Outputs "Thursday" (day 4)






/*
string[] cars = {
    "Volvo", "BMW", "Ford", "Mazda",
     "Honda","Toyota", "Nissan", "Misubishi"
     };
string[] color = {
    "Red", "Green", "Black", "White", 
    "Blue","Cyan", "Yellow", "Dark"};
int i = 0;
int seq =0;
while (i < 8)
{
 
seq++;
  Console.WriteLine(seq+"."+cars[i]+" color is " +color[i]);
  i++;
}*/




string[] ID = {
    "663245001", "663245002", "663245003", "663245004",
     "663245005","663245006", "663245009", "664245025"
     };
string[] prefix = {
    "Mr.", "Mr.", "Mr.", "Mr.", 
    "Mr.","Ms.", "Mr.", "Ms."
    };
string[] firstname = {
    "Kittiphong", "Tanakorn", "Pongsakon", "Watcharapong",
     "Intat","Kannikar", "Kittisak", "Thanporn"
     };
string[] lastname = {
    "Chaimon", "Suphaphut", "Kongngnoi", "Maneengam", 
    "Kanalaksombat","Patposri", "Srisuk", "Hongngam"
    };
int i = 0;
int seq =1;
while (i < 8)
{

  Console.WriteLine((seq++)+" "+"ID."+ID[i]+"  "+prefix[i]+" "+firstname[i]+" " +lastname[i]);
  //Console.WriteLine("{0} {1} {2} {3} {4}", seq++, ID[i], prefix[i], firstname[i], lastname[i]);
  i++;
} // นาย กิตติพงษ์ ใจมน