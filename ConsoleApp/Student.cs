namespace ConsoleApp;

public class Student
{

    //class attributes
    public string fname;
    public string lname;
    public int year;
    public string course;
    public float midtermGrade;
    public float finalGrade;
    public char section;


    // constructor should be no returntype like void
    public Student(string fname,
                    string lname, 
                    int year,
                    string course,
                    char section,
                    float midtermGrade, 
                    float finalGrade)
    { 
   
    //  this.variable = parameter
    this.fname = fname;
    this.lname = lname;
    this.year = year;
    this.course = course;
    this.section = section;
    this.midtermGrade = midtermGrade;
    this.finalGrade = finalGrade;

    }

    public void introduceSelf(){
        Console.WriteLine("Fullname: "+lname+", "+fname);
        Console.WriteLine("Course: "+course);
        Console.WriteLine("Year: "+year);
        Console.WriteLine("Section: "+section);

    }

        public void evaluateGrade(){
        
        Console.WriteLine("Your MidTerm Grade is: "+midtermGrade);
        Console.WriteLine("Your MidTerm Grade is: "+finalGrade);
        Console.WriteLine();

        float grade = midtermGrade +finalGrade;
        float sum = grade/2;
        Console.WriteLine("You averaged: "+ sum);
        if(sum >100) Console.WriteLine("INVALID GRADE. ");
        else if(sum >=98) Console.WriteLine("Congrats! You obtained 'With Highest Honors'");
        else if(sum >=95) Console.WriteLine("Congrats! You obtained 'With High Honors'");
        else if(sum >=90) Console.WriteLine("Congrats! You obtained 'High Honors'");
        else if(sum >=75) Console.WriteLine("You Passed");
        else Console.WriteLine("You Failed.");

        
    
    }
}
