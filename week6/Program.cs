int loop = 0; //วน รับข้อมูล3 รอบ/ชุด

Console.Write("How many reccord to please input :"); //Display เพื่อบอกจำนวน loop ที่จะใช้
loop = Int32.Parse(Console.ReadLine()); // input data int loop

string student_id, prefix, fname, lname, score;

string [][] data = new string [loop][];
string grade;
int point;

// วน loop เพื่อเก็บข้อมูล
for(int i=0; i < loop; i++){

Console.Write("input student id : ");
student_id = Console.ReadLine();

Console.Write("input prefix  : ");
prefix = Console.ReadLine();

Console.Write("input first_name : ");
fname = Console.ReadLine();

Console.Write("input last_name : ");
lname = Console.ReadLine();

Console.Write("input score : ");
score = Console.ReadLine();

Console.WriteLine(".......................................");

// save to data
data[i] = new  string[] {student_id, prefix, fname, lname, score};

}

// วน loop เพื่อแสดงข้อมูล
for(int i=0; i < loop; i++){

// chack grade
 point = Int32.Parse(data[i][4]);
  //ตัดเกรด

 if(point >= 80){
    grade = "A";
 }else if(point >= 75){
    grade ="B+";
 }else if(point >= 70){
    grade = "B";
 }else if(point >= 65){
    grade = "C+";
 }else if (point >= 60){
    grade = "C";
 }else if (point >= 55){
    grade = "D+";
 }else if(point >= 50){
    grade = "D";
 }else if(point == 0 ){
    grade = "I";
 }else{
    grade = "E";
 }



Console.WriteLine("ID :"+ data[i][0] +", Fullname :"+
data[i][1]+
data[i][2]+" "+
data[i][3]+
"grade :"+grade
);



}
