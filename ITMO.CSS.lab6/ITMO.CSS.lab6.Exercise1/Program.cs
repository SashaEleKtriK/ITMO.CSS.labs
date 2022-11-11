using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab6.Exercise1
{

    enum AccountType
    {
        Checking,
        Deposit
    }

    //struct BankAccount
    //{
    //    public long accNo;
    //    public decimal accBal;
    //    public AccountType accType;
    //}
    class BankAccount
    {
        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        public long Number()
        {
            return accNo;
        }

        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            return accType.ToString();
        }



        private long accNo;
        private decimal accBal;
        private AccountType accType;
    }
    class CreateAcc    
    {

        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            //BankAccount created;
            BankAccount created = new BankAccount();

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;
            created.Populate(number, balance);


            return created;
        }

        //static void Write(BankAccount toWrite)
        //{
        //    Console.WriteLine("Account number is {0}", toWrite.accNo);
        //    Console.WriteLine("Account balance is {0}", toWrite.accBal);
        //    Console.WriteLine("Account type is {0}", toWrite.accType.ToString());
        //}
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

    }
}
