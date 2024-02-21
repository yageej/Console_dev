namespace ConsoleApp;

public class Toddler : Person // used to inherit class Person methods and attributes
{

    // This will be the CHILD Class
    // Attribute that will be only available for htis Child Class
    public string t_action{get; set;}


    // if the parent class have constructor, you have to create constructor on the 
    // child class as well. inherit the parameter on parent by using keyword
    // :base(parameters, parameter)
    public Toddler(string fname, string lname, string t_action) : base(fname,lname)
    {
        this.t_action = t_action;
    }

    public void introduceSelf(){

    base.introduceSelf();
        Console.Write("Hello! " +fname+" "+lname+" "+t_action);
    }

}

public class Child : Toddler
{
    // this is an example of inheritance chaining where
    // class Toddler is already a child but another class
    // will inherit its attribute and properties.
    public Child(string fname, string lname, string t_action) 
    : base(fname,lname,t_action)
    {

    }
}
