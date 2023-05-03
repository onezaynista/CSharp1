//All DataTypes

byte Id = 14;
int RollNo = 6542;
short StudentMarks = 1002;
long Cnic = 135045442727;
float ExactMarks = 1002.22f;
string Name = "Bilal Saleem";
bool IsPresent = true;

Console.WriteLine("A Student with id " + Id + " with Roll No is " + RollNo + " and his name is " + Name + " have a cninc " + Cnic +
    " He got " + ExactMarks + " Marks");

//Null Integer

int? one = null;
Console.WriteLine(one);

int? two = 30;
Console.WriteLine(two?? 0);
 
//String Integer

string CName = null;
Console.WriteLine(CName);

string? CName2 = null;
Console.WriteLine(CName2?? "New");





