using System;



namespace ConsoleApp{

    public class Program{
        static void Main(string[] args)
        {

            string[] user = {"geje","quen","pep"};
            string[] pw = {"212121","141414","0404"};            
            bool found = false;
            Console.WriteLine("Enter your UserName: ");
            string user_answer = Console.ReadLine();

            Console.WriteLine("Enter your Password: ");
            string pw_answer = Console.ReadLine();

            for (int index = 0; index < user.Length; index++)
            {
                if(user_answer.Equals(user[index]) && pw_answer.Equals(pw[index])){
                    found = true;
                    Console.WriteLine($"Welcome! {user[index]}");
                }

                if(!found){
                    Console.WriteLine("User not found!");
                }

            }


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

