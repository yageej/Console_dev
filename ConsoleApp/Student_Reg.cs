namespace ConsoleApp;

public class Student_Reg
{
    public string firstName{get;set;}
    public string lastName{get;set;}
    public int year{get;set;}
    public string course{get;set;}
    public string section{get;set;}

    public Student_Reg(string firstName,
                        string lastName,
                        int year,
                        string course,
                        string section)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.year = year;
        this.course = course;
        this.section = section;
    }

    public void studentDetails(){
        Console.WriteLine("** Student Details** ");
        Console.WriteLine(" ");
        Console.WriteLine(" Full Name : "+lastName+", "+firstName);
        Console.WriteLine(" Year      : "+ year);
        Console.WriteLine(" Couse     : "+ course);
        Console.WriteLine(" Section   : "+ section);
        Console.WriteLine(" ");

    }

}
