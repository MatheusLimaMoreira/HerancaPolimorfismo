using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvidoMetodosAbstratos.Entities.Enum;

namespace ExercicioResolvidoMetodosAbstratos.Entities
{
    internal class Clicle : Shape
    {
        public double Radius { get; set; }

        public Clicle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
