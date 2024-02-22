using System;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction Interface
            // way of instantiating an Interface. Dont instantiate using interface
            //always use the class who inherit the interfaces
            Dog_i iaD = new Dog_i();
            iaD.makeSound();
            iaD.walk();
        }
    }
    interface IAnimal // inside interface all method are abstract by default.
    {
        void makeSound(); // this is an abstract method
    }
    interface ILandAnimal
    {
        void walk();
    }

    public class Dog_i : IAnimal, ILandAnimal // this is how to inherit interfaces. You can inherit multi interfacs in 1 class
    {                                         // since this is abstract, it will require to inherit the methods from the interfaces
        public void makeSound() // doesnt need keyword Override. Just copy the method and make a body{} 
        {
            Console.WriteLine("Arf!");
        }

        public void walk() // doesnt need keyword Override. Just copy the method and make a body{} 
        {
            Console.Write("Dog is Walking");
        }
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






            // {
            // // instantiate a class
            // // ClassName identifier = new Classname();
            // // Arithmetic a = new Arithmetic();              // cant instantiate a class with static modifier
            // // Constants cons = new Constants();              

            // // calling diff class methods with public access modifier 
            // // assign to new variable called x
            // int x = Arithmetic.sumOfNumbers(5,3,3);          // access directly once public static is made on the desired class
            // Console.WriteLine(x);

            // Console.WriteLine(Constants.PI);    // access directly even if class is not static as long as the methods inside it are static
            // }



            //             // sample of class instantiation
            // Person Person1 = new Person();
            // Person1.fname = "GJ";     // accessing class attributes
            // Person1.lname = "Argarin"; // accessing class attributes
            // Person1.sex = 'M'; // accessing class attributes
            // Person1.age = 26; // accessing class attributes 

            // Console.Write("Hello "+Person1.fname+ " "+ Person1.lname);
            
            // Person Person2 = new Person();
            // Person2.fname = "GJ";
            // Person2.lname = "Argarin";
            // Person2.sex = 'M';
            // Person2.age = 26;

            // Person Person3 = new Person();
            // Person Person4 = new Person();
            // Person Person5 = new Person();





        // //declare variables for user input
        // string fn = Console.ReadLine();
        // string ln = Console.ReadLine();
        // int gr = Convert.ToInt32(Console.ReadLine());
        // char sec = Convert.ToChar(Console.ReadLine());    
        

        // // instantiate the constructor
        // Student s1 = new Student(fn,ln,gr,sec);







        //Tutorial ChallengeUSer input object creations
        // variables for user input

        // Console.WriteLine("Enter type of Animal: ");
        // string type = Console.ReadLine();
        // Console.WriteLine("Enter breed of Animal: ");
        // string breed = Console.ReadLine();
        // Console.WriteLine("Enter the age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter animal Gender: ");
        // char sex = Convert.ToChar(Console.ReadLine());

        
        // // instantiate constructor
        // Pets p = new Pets(type,breed,age,sex);





             // OBJECT METHODS


        // string n1 = Console.ReadLine();
        // string n2 = Console.ReadLine();
        // int hp1 = Convert.ToInt32(Console.ReadLine());
        
        // // Instantiate class and input constructor parameterss
        // Character_obj CO = new Character_obj(n1,n2,hp1);    
        // // Classname instantiate.ObjectMethod();
        // CO.CharObjMet_greet();

        // //using return so it wont show unless put inside console Writeline
        // Console.WriteLine(CO.CharObjectMet_dialog()); 


    // STUDENT OBJ SIMULATIOn

        // string name,course,sname;
        // int year;
        // float midtermGrade,finalGrade;
        // char sec;

        // Console.Write("Enter your First Name: ");
        // name = Console.ReadLine();
        // Console.Write("Enter your Last Name: ");
        // sname = Console.ReadLine();
        // Console.Write("Enter your Course Name: ");
        // course = Console.ReadLine();
        // Console.Write("Enter your Year: ");
        // year = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter your Midterm Grade: ");
        // midtermGrade = Convert.ToSingle(Console.ReadLine());
        // Console.Write("Enter your FInal Grade: ");
        // finalGrade = Convert.ToSingle(Console.ReadLine());
        // Console.Write("Enter your Section: ");
        // sec = Convert.ToChar(Console.ReadLine());


        // Student stud1 = new Student(name,sname,year,course,sec,midtermGrade,finalGrade);
        // stud1.introduceSelf();
        // stud1.evaluateGrade();


            // ENCAPSULATIOn

            //         int uID = 123;
            // // how to use get set variables in Main

            // //instantiate first
            // User U = new User(uID);  
            // // // SET value
            // // U.UserID = 121;
            // // // GET value
            // // Console.WriteLine(U.UserID);  
            


// overloading constructors

//             // variable
//             int p_id;
//             string p_name;
//             float p_price;

//             Console.WriteLine("Enter Product ID: ");
//             p_id = Convert.ToInt32(Console.ReadLine());
            
//             Console.WriteLine("Enter Product Name: ");
//             p_name = Console.ReadLine();

//             Console.WriteLine("Enter price: ");
//             p_price = Convert.ToSingle(Console.ReadLine());

//             // Overloading Constructor
            
            
//             // Product prod = new Product(p_id,p_name,p_price);
//             // Product prod2 = new Product();
//             Product prod3 = new Product(p_id,p_name);


            






    // Using INHERITANCE, Base class, derived class
            // Person p = new Person("str1", "str2");
            // Toddler t = new Toddler("str3","str4","strAction5");
            // // Console.WriteLine(t.t_action+" "+t.fname+" "+t.lname);

            // p.introduceSelf();
            // t.introduceSelf(); 
            // Child ch = new Child("str6","str7","strAction8");




                        // // Polymorphism - 
            // // you can instantiate like this 
            // // BaseClass B = new DerivedClass()

            // // Animal A = new Animal();
            // // Animal C = new Cat();
            // // Animal D = new Dog();


            // // C.animalSound();
            // // D.animalSound();

            // // POLYMORPHISM CHALLENGE
            // string frarity = "";
            // Console.WriteLine("Enter Anime line: ");
            // string fAnimeLine = Console.ReadLine();
            // Console.WriteLine("Enter Funko Name: ");
            // string fname = Console.ReadLine();
            // Console.WriteLine("Enter Funko Price: ");
            // float fprice = Convert.ToSingle(Console.ReadLine());

            // if(fAnimeLine.Equals("naruto",StringComparison.InvariantCultureIgnoreCase))
            // {
            // //Instantiating Base class to Derived Class
            // FunkoPopLine NL = new NarutoLine();
            // NL.printFunkoDetails(fname,fprice,frarity,fAnimeLine);
            // }
            // else if(fAnimeLine.Equals("mha",StringComparison.InvariantCultureIgnoreCase))
            // {
            // FunkoPopLine MHAL = new MyHeroAcademia();
            // MHAL.printFunkoDetails(fname,fprice,frarity,fAnimeLine);
            // }
            // else
            // {
            //     Console.WriteLine("Invalid ANime line. Exiting program.");
            // }

            // //instantiate base class
            // FunkoPopLine FPL = new FunkoPopLine();
            // // FPL.printFunkoDetails(fname,fprice,frarity,fAnimeLine);
            




          // Abstraction -

            //Abstract classes shouldnt be instantiated on base class
            //instantiate it on Derived class
            // wrong sample
            // AnimalAbstract AA = new AnimalAbstract();
            // corret sample
            // AnimalAbstract AT = new Tiger("string1", "string2");
            // AT.animalSound();