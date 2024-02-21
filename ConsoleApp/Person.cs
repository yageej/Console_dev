namespace ConsoleApp;

public class Person
{
    // This is will be the BASE CLASS
    //Attributes
    public string fname{get; set;}
    public string lname{get; set;}
    public char sex{get; set;}
    public int age{get; set;}

    // Base Class w Constructor w parameter 
    public Person(string fname, string lname){
        this.fname = fname;
        this.lname = lname;
    }

    // Base Method
    public void introduceSelf(){
    
    }

}
