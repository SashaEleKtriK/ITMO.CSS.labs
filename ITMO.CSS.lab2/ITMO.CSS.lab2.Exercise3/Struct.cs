using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab2.Exercise3
{
    public enum AccountType { Checking, Deposit }
    public struct Account { public long accNo; public decimal accBal; public AccountType accType; }
    internal class Struct
    {
        static void Main(string[] args)
        {
            Account goldAccount;
            Console.Write("Enter account number: ");
            int accNo = int.Parse(Console.ReadLine());
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = accNo;


            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);


        }
    }
}
