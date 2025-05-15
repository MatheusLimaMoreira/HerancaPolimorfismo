
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao_Virtuan_Overide.Entities
{
    internal class SavingsAccount : Account

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

        public override void withdraw(double amount)
        {
            base.withdraw(amount);
            Balance -= 2.0; // Overriding the base class method to add an additional fee
        }
    }
}
