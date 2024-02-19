namespace ConsoleApp;

public class Student
{

    //class attributes
    public string fname;
    public string lname;
    public int grade;
    public char section;


    // constructor should be no returntype like void
    public Student(string firstname, string lastname, int grade, char section)
    { 
   
    //  this.variable = parameter

        this.fname = firstname;
        this.lname = lastname;
        this.grade = grade;
        this.section = section;

        Console.WriteLine("Student Created");
        Console.WriteLine(firstname + " " + lastname);
        Console.WriteLine(grade+ " "+ section);


    }

}
