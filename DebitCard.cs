using System;

namespace DebitCard
{
    class DebitCard
    {
        public string BankName { get; set; }

        public string CardNumber { get; set; }

        public int CVV { get; set; }

        public string ExpiryDate { get; set; }
        public string OwnerName { get; set; }

        public string OwnerSurname { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal sum)
        {

            if (sum <= 0) return;
            Balance += sum;

        }

        public void Withdraw(decimal sum)
        {
            if (sum >= 0) return;
            Balance += sum;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DebitCard myDebitCard = new DebitCard();

            myDebitCard.BankName = "AccessBank";
            myDebitCard.CardNumber = "2818376250382938";
            myDebitCard.OwnerName = "Steve";
            myDebitCard.OwnerSurname = "Pond";
            myDebitCard.CVV = 901;
            myDebitCard.ExpiryDate = "11/24";
            myDebitCard.Deposit(100);
            myDebitCard.Withdraw(-50);
            Console.WriteLine(myDebitCard.Balance);
        }
    }
}