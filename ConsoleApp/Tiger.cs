namespace ConsoleApp;

public class Tiger : AnimalAbstract
{
    public override void animalSound() //abstract method once inherited should have body
    {
        Console.WriteLine("ROAR!");
    }
}
