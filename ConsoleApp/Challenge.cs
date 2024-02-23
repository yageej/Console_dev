using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp;

public class Challenge
{
    public static void Main(string[] args){

////////////// Sentence Builder Challenge & User Input
            // Console.WriteLine("Enter name:  ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Enter age:  ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter gpa:  ");
            // float gpa = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Enter gender:  ");
            // char sex = Convert.ToChar(Console.ReadLine());

            // Console.WriteLine("Hi my name is "+name);
            // Console.WriteLine("I am "+age+"years old");
            // Console.WriteLine("My GPA is "+gpa);
            // Console.WriteLine("My sex is "+sex);

////////////// Average Calculator
            
            // Console.WriteLine("Input English grade: ");
            // int english = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input Math grade: ");
            // int math = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input Science grade: ");
            // int science = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input Computer grade: ");
            // int computer = Convert.ToInt32(Console.ReadLine());

            // float avg = (english+math+science+computer)/4;

            // Console.WriteLine("Average: "+avg);

////////////// Grade Average Program
            
            // Console.WriteLine("Input English grade: ");
            // float english = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Input Math grade: ");
            // float math = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Input Science grade: ");
            // float science = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Input Computer grade: ");
            // float computer = Convert.ToSingle(Console.ReadLine());

            // float avg = (english+math+science+computer)/4;

            // Console.WriteLine("You Averaged: "+ avg);
            // if(avg > 100) Console.WriteLine("Invalid Grade");
            // else if(avg >= 98) Console.WriteLine("With Highest Honors");
            // else if(avg >= 95) Console.WriteLine("With High Honor");
            // else if(avg >= 90) Console.WriteLine("With Honors");
            // else if(avg >= 75) Console.WriteLine("Passed");
            // else Console.WriteLine("Failed");


////////////// Date Formatter
            // Console.WriteLine("Enter Month: ");
            // int month = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Date: ");
            // int date = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Year: ");
            // int yr = Convert.ToInt32(Console.ReadLine());

            // string Emonth;
            // switch(month){
            //     case 1:
            //             Emonth = "January";
            //             Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 2:
            //             Emonth = "February";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 3:
            //             Emonth = "March";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 4:
            //             Emonth = "April";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 5:
            //             Emonth = "May";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 6:
            //             Emonth = "June";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 7:
            //             Emonth = "July";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 8:
            //             Emonth = "August";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 9:
            //             Emonth = "September";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 10:
            //             Emonth = "October";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 11:
            //             Emonth = "November";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            //     case 12:
            //             Emonth = "December";
            //         Console.WriteLine(Emonth+" "+ date+", "+yr);
            //     break;
            // }

///////////// QUIZ GAME w Lives

                // int life = 5;

                // for (int i = 0; i < life; i++)
                // {
                //     Console.WriteLine("What is 2+2");
                //     int answer = Convert.ToInt32(Console.ReadLine());
                //     if (answer == 4){
                //         Console.WriteLine("You Won!");
                //         break;
                //     }
                //     else Console.WriteLine("Wrong!");
                //     if(life == 0) Console.WriteLine("Game over!");
                // }


///////////// Array of Integers Summation

                // int[] arrayOfNumbers = {1,2,3,4,5,6};
                // int sum = 0;

                // foreach (var item in arrayOfNumbers)
                // {
                //     sum += item;
                // }
                // Console.WriteLine(sum);

///////////// Array of Integers Summation
        //     int[] arrayOfNumbers = {1,2,3,4,5,6};
        //      summation(arrayOfNumbers); //method
           

        // void summation(int[] arr){
        //     int sum = 0;
        //     foreach (var item in arr)
        //     {
        //         sum += item;

        //     }
        //     Console.WriteLine(sum);
        // }

///////////// USER INPUT OBJECT CREATION 
//             string uname = Console.ReadLine();

//             Anime anime = new Anime(uname);

//     }
// }

// public class Anime{
//     string name{get;set;}
//     public Anime(string name){
//         this.name = name;
//         Console.WriteLine("Hi Anime!"+name);
//     }
// }



///////////////   STUDENT OBJECT SIMULATION & Polymorphissm

//     Console.Write("What is your first name: ");
//     string name = Console.ReadLine();
//     Console.Write("What is your last name: ");
//     string lname = Console.ReadLine();
//     Console.Write("What is your midterm grade: ");
//     float mg = Convert.ToSingle(Console.ReadLine());

//     Console.Write("What is your final grade: ");
//     float fg = Convert.ToSingle(Console.ReadLine());

//     StudentObj student = new StudentObj(name,lname,mg,fg);
//     student.introduceSelf(name,lname);
//     student.evaluateGrade(mg,fg);

//     StudObj student2 = new StudObj(name,lname,mg,fg);
//     student2.introduceSelf(name,lname);


//     }
// }

// public class StudentObj{
//     string fname{get;set;}
//     string lname{get;set;}
//     float midtermgrade{get;set;}
//     float finalgrade{get;set;}
    
//     public StudentObj(string fname, string lname, float midtermgrade, float finalgrade){
//         this.fname = fname;
//         this.lname = lname;
//         this.midtermgrade = midtermgrade;
//         this.finalgrade = finalgrade;
//     }
//     public virtual void introduceSelf(string fname, string lname){
//         Console.WriteLine("Hi I am"+fname+" "+lname);
//     }

//     public void evaluateGrade(float midtermgrade, float finalgrade){
//         float avg = (midtermgrade+finalgrade)/2;
//             Console.WriteLine("You Averaged: "+ avg);
//             if(avg > 100) Console.WriteLine("Invalid Grade");
//             else if(avg >= 98) Console.WriteLine("With Highest Honors");
//             else if(avg >= 95) Console.WriteLine("With High Honor");
//             else if(avg >= 90) Console.WriteLine("With Honors");
//             else if(avg >= 75) Console.WriteLine("Passed");
//             else Console.WriteLine("Failed");

//     }


// }


// public class StudObj : StudentObj
// {
//     public StudObj(string fname, string lname, float midtermgrade, float finalgrade) : base(fname, lname, midtermgrade, finalgrade)
//     {

//     }

//     public override void  introduceSelf(string fname, string name){
//         Console.WriteLine("HI IM NOT"+name);











Console.WriteLine("Input Number of students: ");
int numOfStudents = Convert.ToInt32(Console.ReadLine());



    Student_registration[] studR = new Student_registration[numOfStudents];

        for (int i = 0; i < numOfStudents; i++)
        {

                Console.Write("What is your first name: ");
                string name = Console.ReadLine();
                Console.Write("What is your last name: ");
                string lname = Console.ReadLine();
                studR[i] = new Student_registration(name, lname);
            
        }
        foreach (Student_registration item in studR)
        {
            item.introduceSelf();
        }
    }
}



/////// STUDENT REGISTRATION SIMULATION



public class Student_registration{
    string fname{get;set;}
    string lname{get;set;}


public Student_registration(string fname, string lname){
this.fname = fname;
this.lname = lname;

}

public void introduceSelf(){
    
    Console.WriteLine("Hi im"+fname+" "+lname);
}
}