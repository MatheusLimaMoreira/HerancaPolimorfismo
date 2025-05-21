using ExercicioFixacao02.Entities;

namespace ExercicioFixacai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberofEmployees));
                }
            }

            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2"));
            }

            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}
