using System;
using System.Dynamic;
using System.Globalization;



namespace ConsoleApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            // instantiate a class
            // ClassName identifier = new Classname();
            Arithmetic a = new Arithmetic();
            Constants cons = new Constants();

            // calling diff class methods with public access modifier 
            // assign to new variable called x
            int x = a.sumOfNumbers(5,3,3);
            Console.WriteLine(x);

            Console.WriteLine(cons.PI);
        }
    }

    class SampleClassInsideMainClass
    {
        
    }

}

        // Quiz Game w/ Lives recap

        // int u_life = 5;


        // while(u_life > 0)
        // {
        //     Console.WriteLine("Life remaining: "+u_life);
        //     Console.WriteLine("Who is the strongest Anime Protagonist?");
        //     Console.WriteLine("Who is the strongest Anime Protagonist?");
        //     string answer = Console.ReadLine();
        //     if(answer.Equals("goku",StringComparison.InvariantCultureIgnoreCase))
        //         {

        //             Console.WriteLine("You are correct!" + " The strongest Character is always "+answer);
        //             break;
        //         }
        //      else
        //         {
        //             Console.WriteLine("INCORRECT!");
        //             u_life--;
        //         }
                       
        //     if(u_life == 0){
        //         Console.WriteLine("Game over");
        //     }
        // }



            // // Authentication Simulation Demo code
            // string[] user = {"geje","quen","pep"};
            // string[] pw = {"212121","141414","0404"};            
            // bool found = false;
            // Console.WriteLine("Enter your UserName: ");
            // string user_answer = Console.ReadLine();

            // Console.WriteLine("Enter your Password: ");
            // string pw_answer = Console.ReadLine();

            // for (int index = 0; index < user.Length; index++)
            // {
            //     if(user_answer.Equals(user[index]) && pw_answer.Equals(pw[index])){
            //         found = true;
            //         Console.WriteLine($"Welcome! {user[index]}");
            //     }

            //     if(!found){
            //         Console.WriteLine("User not found!");
            //     }

            // }



           // 2D Array -- Array within an Array [rows, column]


            // string[,] array2D = 
            // {
            //     {"Pepper", "Potss"},
            //     {"GJ", "Argarin"},
            //     {"Quen", "Alba"},
            //     {"GG", "QQ"},
            // };


            // 2D array in nested foreach loops
            // foreach(string x in array2D){
            //     Console.WriteLine($" {x}");
            // }

            // Console.WriteLine(array2D.GetLength(0)); // lenght of row in 2D array
            // Console.WriteLine(array2D.GetLength(1)); // lenght of col in 2D array
            
            // Console.WriteLine(array2D[3,1]);
            // array2D[3,1] = "EYYY";
            // // Console.WriteLine(array2D[0,1]);
            // // Console.WriteLine(array2D[0,0]);
            // Console.WriteLine(array2D[3,1]);
// Console.WriteLine($"Hi Dog! you're {array2D[0,0]} {array2D[0,1]}? ");
         
            
            



                // // nested for loop
                //     //normal for loop
                //     for (int i = 0; i < 5; i++)
                //     {
                //         for(int x = 0; x < 5; x++)
                //         {
                //             Console.WriteLine(x);
                //         }
                //         Console.WriteLine();
                //     }




   // For each loop // Arrays of Integers summation


            // int [] numbers = {1,2,3,4,5};

            // int sum = 0;

            // foreach (var n1 in numbers)
            // {
            //     sum += n1;

            // }
            // Console.WriteLine("total: "+sum);


            // string[] names = {"GJ","GJJJ", "GASD"};

            // foreach(var name in names){
            //     if(name.Equals("GJJJ")){
            //         Console.WriteLine("Hi, "+name);
            //         break;
            //     }
            // }
            



        //             //Overloading methods - same method with diff parameters/Argu
        // static int add(int n1, int n2)
        // {   
        //     return n1 + n2;
        // }

        // static int add(int n1, int n2,int n3)
        // {   
        //     return n1 + n2 + n3;
        // }





                // Global variables -- needs to have static before datatype
        // static string name = "GJ";

        // summation of Numbers using methods

        // static void Main(string[] args)
        // {
        //     int[] arrayofInt = {1,2,3,4,5,5,1}; // sample array
        //     Console.WriteLine(addMethod(arrayofInt)); //passed array variable to method parameters/arguements
        // }
    
        // static int addMethod(int[] arrNumbers) // parameter is array of int
        // {
        //     int sum = 0;
        //     for (int index = 0; index < arrNumbers.Length; index++)
        //     {
        //         sum += arrNumbers[index]; // added arrnumbers value per loop
        //     }
        //     return sum; // return total
        // }