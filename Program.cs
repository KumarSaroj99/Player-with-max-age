using PlayerAgg.Models;

namespace PlayerAgg
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Player[] players = { 
                new Player(100, "Raj", 22),
                new Player(101, "Raju", 21), 
                new Player(102, "Sam", 24),
                new Player(104, "Ram", 20),
                new Player(105, "Karan", 26) };

            Player elder=Player.WhoIsElder(players);
            Console.WriteLine(elder);
        }
    }
}
