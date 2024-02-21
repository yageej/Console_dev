namespace ConsoleApp;

public class MyHeroAcademia : FunkoPopLine
{
    // Derived
    public override void printFunkoDetails(string funkoName, 
                                            float funkoPrice, 
                                            string funkoRarity,
                                            string funkoAnimeLine)
    {
        if(funkoName.Equals("Allmight",StringComparison.InvariantCultureIgnoreCase)){
        Console.WriteLine("Funko Name: "+funkoName);
        Console.WriteLine("Funko Price: "+funkoPrice);
        Console.WriteLine("Congrats! "+funkoName+ " is RARE from MHA LINE!");
        Console.WriteLine("Funko Line: "+funkoAnimeLine);
        Console.WriteLine();
        }
        else{
        Console.WriteLine("Funko Name: "+funkoName);
        Console.WriteLine("Funko Price: "+funkoPrice);                
        Console.WriteLine("Funko Rarity: Normal");
        Console.WriteLine("Funko Line: "+funkoAnimeLine);
        Console.WriteLine();
        }
    }
}
