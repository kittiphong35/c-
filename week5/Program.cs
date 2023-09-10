
string[][] data = new string[10][];
data [0]= new string[] {"654245001", "Mr.", "Nuttapon","Boonrd", "75"};
data [1]= new string[] {"654245004", "Mr.", "Tanavin","Puangsombut", "82"};
data [2]= new string[] {"654245005", "Mr.", "Paruepun","Jumroonrap", "56"};
data [3]= new string[] {"654245006", "Mr.", "Phuri","Parompasert", "66"};
data [4]= new string[] {"654245007", "Mr.", "Phurin","Jitpitipramot", "71"};
data [5]= new string[] {"654245009", "Mr.", "Sittipon","supannopao", "54"};
data [6]= new string[] {"654245010", "Mr.", "Anusorn","Kanin", "48"};
data [7]= new string[] {"654245011", "Mr.", "Apiwatkitsri","Srionrod", "79"};
data [8]= new string[] {"654245012", "Ms.", "Sasikan","Janwan", "66"};
data [9]= new string[] {"654245013", "Ms.", "Thidawan","Shukarum", "58"};

int Count;
int point; 
string grade;


Count = data.Length;

Console.WriteLine(Count);
//int i = 0;
for(int i=0; i< Count; i++){
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

    Console.WriteLine(
         "Student ID is :"+data[i][0]+" "+
         "Fullname is :"+data[i][1]+" "+
         data[i][2]+" "+
         data[i][3]+" "+
         "Grade is : "+ grade
          );
}