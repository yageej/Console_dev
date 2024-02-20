using System.Dynamic;

namespace ConsoleApp;

public class User
{
    // Private Attributes /fields
    private int userID;
    private string Usernamel,firstName,lastName;

    // using getter and setter

    // properties
    public int UserID // this is used to encapsulate private attributes and make it available on other classes
    {
        get{ return userID; }
        set{ 
            if(value < 121) userID = value;
            else Console.WriteLine("Value must be less than 121"); 
            }
    }

    //Create a constructor
    public User(int userid){
        //syntax getter = parameter
        UserID = userid;
    }


}

// automatic properties

    // public int UserID
    // {get; set;}


    // public User(int userID)
    // {
    //     this.UserID = userID;
    //     Console.Write(UserID);
    // }