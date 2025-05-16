using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class Employee
    {
        public string? Name { get; set; }
        public double Houers { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }
        public Employee(string name, double houers, double valuePerHour)
        {
            Name = name;
            Houers = houers;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Houers * ValuePerHour;
        }
    }    
}
