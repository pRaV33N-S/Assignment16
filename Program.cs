using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount bank = new BankAccount("Praveen");
                bool flag = true;
                flag = bank.Deposit(5000);
                flag = bank.Withdraw(500);
                if (flag)
                    bank.Display();
                BankAccount bank2 = new BankAccount("Srinivasan");
                flag = true;
                flag = bank2.Deposit(100000);
                flag = bank2.Withdraw(3000);
                if (flag)
                    bank2.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
