using AccountFormatLibrary;
using System;

namespace BankingLibraryPorject {
    public class Account {
        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest-bearing account";
        public decimal Balance { get; set; } = 100m;
        public decimal InterestRate { get; set; } = 0.12m;

        public decimal CalculateInterest(int months) {                                       //calling back to the AccountLibray
            decimal interestAmount                                                           //use 'FormatAccount.' because CalcIntByMth 
                = FormatAccount.CalculateInterestByMonths(months, InterestRate, Balance);    //is static in its library formats
            Balance += interestAmount;
            return interestAmount;
        }
    }
}
