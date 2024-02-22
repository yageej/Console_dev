namespace ConsoleApp;

public abstract class AnimalAbstract
{
    string name{get;set;}
    string weight{get;set;}

    //we can create constructor inside abstract class
    public AnimalAbstract(string name, string weight){
        this.name = name;
        this.weight = weight;
    }
    public abstract void animalSound(); // this method doesnt have curly braces

    public void animalWeight(){  // you can still create normal method inside an abstract class

    }
}
