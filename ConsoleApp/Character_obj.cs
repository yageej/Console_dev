using System.Net;

namespace ConsoleApp;

public class Character_obj
{
    //attribute
    public string name, dialog;
    public int hp,mp,lvl;

    public Character_obj(string name, string dialog,int hp)
    {
        //this.variable = parameter
        this.name = name;
        this.dialog = dialog;
        this.hp = hp;



    }

    // sample of obj method
    public void CharObjMet_greet()
    {
        Console.WriteLine("Hi "+name);

        
    }
    // sample of obj method
    public string CharObjectMet_dialog(){
        return "Voiceline: " +dialog;
    }
   

}
