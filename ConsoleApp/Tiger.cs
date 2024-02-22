namespace ConsoleApp;

public class Tiger : AnimalAbstract
{

    //constructor from abstract class should be overridden as well on derived class
    public Tiger(string name, string weight) :base(name,weight) {}
    public override void animalSound() //abstract method once inherited should have body
    {
        Console.WriteLine("ROAR!");
    }
}



