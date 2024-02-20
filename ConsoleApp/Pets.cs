namespace ConsoleApp;

public class Pets
{
    //Attributes
    string p_type;
    string p_breed;
    int p_age;
    char p_sex;




    //Constructor with parameters/arguments
    public Pets(string p_type, string p_breed,int p_age,char p_sex){
        
        //syntax this.variable = argument/parameter
        this.p_type = p_type;
        this.p_breed = p_breed;
        this.p_age = p_age;
        this.p_sex = p_sex;


        Console.WriteLine($"Type of Animal: {p_type}");
        Console.WriteLine($"Breed of Animal: {p_breed}");
        Console.WriteLine($"Age of Animal: {p_age}");
        Console.WriteLine($"Sex of Animal: {p_sex}");

        if(p_sex.Equals('F')){
            Console.WriteLine($"COngrats you have princess {p_type}");
        }

    }


}
