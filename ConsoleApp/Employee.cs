namespace ConsoleApp;

public class Employee
{
    public string firstName{get;set;}
    public string lastName{get;set;}
    public string position{get;set;}
    public double salary{get;set;}

    public Employee(string firstName, 
                    string lastName, 
                    string position, 
                    double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.position = position;
        this.salary = salary;
    }
    public void introduceSelf(){
    Console.WriteLine("I am "+ firstName+ " "+ lastName);   
    }

}
