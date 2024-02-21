namespace ConsoleApp;

public class FunkoPopLine
{
    //Base class
    string funkoName{get;set;}
    float funkoPrice{get;set;}
    string funkoRarity{get;set;}
    string funkoAnimeLine{get;set;}

    public virtual void printFunkoDetails(string funkoName, 
                                         float funkoPrice, 
                                         string funkoRarity,
                                         string funkoAnimeLine)
        {
        Console.WriteLine("Funko Name: "+funkoName);
        Console.WriteLine("Funko Price: "+funkoPrice);
        Console.WriteLine("Funko Rarity: "+funkoRarity);
        Console.WriteLine("Funko Line: "+funkoAnimeLine);
        Console.WriteLine();
    }


}
