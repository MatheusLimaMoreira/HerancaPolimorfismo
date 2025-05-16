using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; set; }
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, double houers, double valuePerHour, double addicionalCharge)
            : base(name, houers, valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddicionalCharge ;
        }
    }
}
