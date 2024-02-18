using System;



namespace ConsoleApp{

    public class Program{
        static void Main(string[] args){

        // Quiz Game w/ Lives recap

        int u_life = 5;


        while(u_life > 0)
        {
            Console.WriteLine("Life remaining: "+u_life);
            Console.WriteLine("Who is the strongest Anime Protagonist?");
            Console.WriteLine("Who is the strongest Anime Protagonist?");
            string answer = Console.ReadLine();
            if(answer.Equals("goku",StringComparison.InvariantCultureIgnoreCase))
                {

                    Console.WriteLine("You are correct!" + " The strongest Character is always "+answer);
                    break;
                }
            else if(u_life >= 1)
                {
                    Console.WriteLine("INCORRECT! Guess again!");
                    u_life--;
                }
             else
                {
                    Console.WriteLine("INCORRECT!");
                    u_life--;
                }
                       
            if(u_life == 0){
                Console.WriteLine("Game over");
            }
        }



        }
    }

}
