using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSS.lab8.Exercise1
{
    enum AccountType
    {
        Checking,
        Deposit
    }

  

    class BankAccount
    {
        public BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }

        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }

        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }

        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }

        //public void Populate(decimal balance)
        //{
        //    accNo = NextNumber();
        //    accBal = balance;
        //    accType = AccountType.Checking;
        //}
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

        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }





        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;
    }
    class CreateAcc
    {

        public static void Main()
        //{
        //    BankAccount b1 = new BankAccount();
        //    b1.Populate(100);

        //    BankAccount b2 = new BankAccount();
        //    b2.Populate(100);

        //    Console.WriteLine("Before transfer");
        //    Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
        //    Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

        //    b1.TransferFrom(b2, 10);

        //    Console.WriteLine("After transfer");
        //    Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
        //    Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());
        //}

        {
            BankAccount acc1, acc2, acc3, acc4;

            acc1 = new BankAccount();
            acc2 = new BankAccount(AccountType.Deposit);
            acc3 = new BankAccount(100);
            acc4 = new BankAccount(AccountType.Deposit, 500);

            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
        }


        //static BankAccount NewBankAccount()
        //{
            
        //    BankAccount created = new BankAccount();


        //    Console.Write("Enter the account balance! : ");
        //    decimal balance = decimal.Parse(Console.ReadLine());
        //    created.Populate(balance);


        //    return created;
        //}

   
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());

        }
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds.");
            }
        }


    }
}
