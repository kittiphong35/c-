
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

BMI = height/weight;

BMI = Math.Pow(BMI,2);

Console.WriteLine("BMI is"+BMI);      