

namespace Exerc_125.Entities.Class
{
    class BusinesssAccount : Account
    {
        public double LoanLimit { get; set; }


        public BusinesssAccount()
        {

        }
        public BusinesssAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

    }
}

