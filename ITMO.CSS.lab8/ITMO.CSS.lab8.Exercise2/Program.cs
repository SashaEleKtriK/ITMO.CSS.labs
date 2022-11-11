using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ITMO.CSS.lab8.Exercise2
{
    enum AccountType
    {
        Checking,
        Deposit
    }


    class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;

        public decimal Amount()
        {
            return amount;
        }

        public DateTime When()
        {
            return when;
        }

        public BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }



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
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;

        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;

        }
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }


        public Queue Transactions()
        {
            return tranQueue;
        }


        private Queue tranQueue = new Queue( );
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;
    }
    class CreateAcc
    {

        public static void Main()

        {
            BankAccount acc1, acc2, acc3, acc4;

            acc1 = new BankAccount();
            acc2 = new BankAccount(AccountType.Deposit);
            acc3 = new BankAccount(100);
            acc4 = new BankAccount(AccountType.Deposit, 500);

            //Write(acc1);
            //Write(acc2);
            //Write(acc3);
            //Write(acc4);

            acc3.Withdraw(150);
            Write(acc3);
            acc3.Withdraw(50);
            Write(acc3);
            acc4.Withdraw(100);
            Write(acc4);
           
            


        }



        //static void Write(BankAccount toWrite)
        //{
        //    Console.WriteLine("Account number is {0}", toWrite.Number());
        //    Console.WriteLine("Account balance is {0}", toWrite.Balance());
        //    Console.WriteLine("Account type is {0}", toWrite.Type());

        //}
        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();

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
