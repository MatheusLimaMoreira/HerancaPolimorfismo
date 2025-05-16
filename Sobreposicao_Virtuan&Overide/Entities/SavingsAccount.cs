
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao_Virtuan_Overide.Entities
{
    sealed class SavingsAccount : Account // Evita que a classe seja herdada.

    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void withdraw(double amount) 
        {
            Balance -= amount;
        }
        */

        public sealed override void withdraw(double amount) // Evita que o metodo seja sobrescrito em uma subclasse.
        {
            base.withdraw(amount);
            Balance -= 2.0; // Overriding the base class method to add an additional fee
        }
    }
}
 