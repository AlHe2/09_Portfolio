using System;

namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {
        public string Id { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public SavingsAccount(string id, double balance, double interest) {
            this.Id = id;
            this.Balance = balance;
            this.InterestRate = interest;
        }
        public override string ToString() {
            return "SavingsAccount[value=" + this.Balance + ",interestRate=" + this.InterestRate + "]";
        }

        public double GetValue() {
            return this.Balance;
        }

        internal void ApplyInterest() {
            double interest = (this.Balance * this.InterestRate) / 100;
            this.Balance = this.Balance + interest;
        }

    }
}