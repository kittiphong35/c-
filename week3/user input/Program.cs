/*
string fname = "";
double height = 0;
double weight = 0.0d;
double BMI =0.0d;

Console.Write("input first name : ");                 //display  ชื่อ
fname = Console.ReadLine();                          //input keyboard

Console.Write("input height : ");               //display ส่วนสูง
height = double.Parse(Console.ReadLine());          //input keyboard and convertheight 

Console.Write("input weight : ");               //display น้ำหนัก
weight = double.Parse(Console.ReadLine());          //input keyboard and convertheight 

BMI = height/weight;                    //หาร

BMI = Math.Pow(BMI,2);                  //การทำงาน

Console.WriteLine("BMI is"+BMI);      //หาค่ดัชนี */

string prefix ="";
string firstname = "";
string lastname = "";
int ID = 0;
double height = 0;
double weight = 0.0d;
double BMI =0.0d;

Console.Write("input prefix : ");                 //display  ชื่อ
 prefix = Console.ReadLine();                          //input keyboard

Console.Write("input first name : ");                 //display  ชื่อ
firstname = Console.ReadLine();                          //input keyboard

Console.Write("input last name : ");                         //display  ชื่อ
lastname = Console.ReadLine();                          //input keyboard

Console.Write("input student ID : ");                            
ID = Int32.Parse(Console.ReadLine());                          //input keyboard

Console.Write("input you of height: ");                 //display  ชื่อ
height = double.Parse(Console.ReadLine());                          //input keyboard

Console.Write("input you of weight: ");                 //display  ชื่อ
weight = double.Parse(Console.ReadLine());

BMI = height/weight;                    //หาร

BMI = Math.Pow(BMI,2);                  //การทำงาน



Console.WriteLine("********************");
Console.WriteLine("student ID is : "+ID);
Console.WriteLine("Full name is : "+prefix+firstname+" "+lastname);
Console.WriteLine("iuput height : "+height);
Console.WriteLine("iuput weight : "+weight);
Console.WriteLine("BMI is"+BMI);
Console.WriteLine("********************");
