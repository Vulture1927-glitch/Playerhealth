using Playerhealth;
namespace Main
{
    public class Program
    {
        static void Main()
        {
            Player player = new Player();
            bool codeRunning = true;
            while (codeRunning)
            {
                Console.WriteLine($"Player has {player.Health} health, what do you do? (Type word)\n" +
                    "1.Attack\n" +
                    "2.Heal\n" +
                    "3.End");
                string response = Console.ReadLine().Trim().ToLower();
                switch (response)
                {
                    case "attack":
                        Console.WriteLine("How much?");
                        int damage = int.Parse(Console.ReadLine());
                        player.TakeDamage(damage);
                        if(player.Health <=0)
                        {
                            codeRunning = false;
                        }
                        break;
                    case "heal":
                        Console.WriteLine("How much?");
                        int replenish = int.Parse(Console.ReadLine());
                        player.TakeDamage(replenish);
                        break;
                    case "end":
                        codeRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid operation");
                        break;

                }

            }
        }
    }


}
