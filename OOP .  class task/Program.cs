// Dersin Praktikasi, OOP , Class .


//int CountOfCharsArray(string[] words, char c)
//{
//    int count = 0;

//    foreach (var word in words )
//    {
//        foreach (var letter in word )
//        {
//            if (letter == c)
//            {
//                count++;
//            }
//        }
//    }
//    return count;
//}

//Console.WriteLine(CountOfCharsArray(new string[] {"Cavid","Kamran"},'a'));


//string name1 = "Emiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;


//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;


//string name3 = "Elmir";
//string surname3 = "Qafarzde";
//int age3 = 21;

//Console.WriteLine($"{name2} {surname2} {age2}");


//var stu1 = new
//{
//    name ="Emiraslan",
//    surname= "Miriyev",
//    age=33

//};


//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22

//};


//var stu3 = new
//{
//    name = "Elmir",
//    surname = "Qafarzade",
//    age = 33

////};

//Console.WriteLine(stu1);

//Console.WriteLine(stu1.name +" "+stu1.surname+" "+stu1.age);



using OOP_.__class_task;
using System.Data;

Student stu1 = new Student();   

stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";


Student stu2 = new();
stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.address = "Xetai";
stu2.phone= "1234567890";

//Console.WriteLine(stu1.name);

//string fullName = stu2.name + " " + stu2.surname;

//Console.WriteLine(fullName);


Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22,
    address = "Masazir",
    phone="12233445"

};


//Console.WriteLine(stu3.GetFullname());

//var result= stu2.GetFullDatas ();

//Console.WriteLine(result);  



//Student[] students = { stu1, stu2, stu3 };

//foreach ( var item in students)
//{
//    // Console.WriteLine(stu.name +' '+stu.surname);
//    Console.WriteLine(item.GetFullDatas());

//}


// void ShowAll(Student[] datas)
//{
//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.GetFullDatas());

//    }
//}

//ShowAll(students);


Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{

//    Student foundstudent = new();

//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            foundstudent = item;
//            break;
//        }
//    }
//    return foundstudent;
//}


//int a = 8;

//Console.WriteLine(a == 5 ? a : "deyil");

//var result = 5 == 5 ? a.ToString() : "deyil";

//Console.WriteLine( 5);

//Console.WriteLine("salam");

Student GetByAge(Student[] datas, int age) 
{   
     return  datas.FirstOrDefault(m => m.age == age);
    
}

var result = GetByAge (students ,24);

if (result != null)
{
    Console.WriteLine(result.GetFullDatas());
}
else
{
    Console.WriteLine("Data notfound");

}
