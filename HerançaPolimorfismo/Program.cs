using Herança.Entities;

namespace HerançaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new 
                BusinessAccount(8010, "Bob Brow ", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            
            }
    }
}
   