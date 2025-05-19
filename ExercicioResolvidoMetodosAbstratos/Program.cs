using ExercicioResolvidoMetodosAbstratos.Entities;
using ExercicioResolvidoMetodosAbstratos.Entities.Enum;

namespace ExercicioResolvidoMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> List = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    List.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    List.Add(new Clicle(radius, color));
                }               
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in List)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
