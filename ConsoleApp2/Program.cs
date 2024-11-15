public class Buzz
{
    public static void Baffle(string blimp)
    {
        Console.WriteLine(blimp);//#4
        Zippo("ping", -5);//#5
    }
    public static void Zippo(string quince, int flag)
    {
        if (flag < 0)
        {
            Console.WriteLine(quince + " zoop");//#6
        }
        else
        {
            Console.WriteLine("ik");//#2
            Baffle(quince);//#3
            Console.WriteLine("boo-wa-ha-ha");
        }
    }
    public static void Main(string[] args)
    {
        Zippo("rattle", 13);//#1
    }
}

//What is the value of the parameter blimp when Baffle gets invoked?

//Baffle is called with quince = "rattle", which is passed as the blimp 
//parameter in Baffle. So, the value of blimp is "rattle".

//What is the output of this program?

//The program's output, in order, is:
//    ik
//    rattle
//    ping zoop
//    boo-wa-ha-ha