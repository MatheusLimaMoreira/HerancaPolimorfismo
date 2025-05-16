using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Entities.Employee> list = new List<Entities.Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                double hours = double.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y') // adicionando os dados na lista.
                {
                    Console.Write("Additional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee
                        (name, hours, valuePerHour, addicionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
            }
        }
    }
}
