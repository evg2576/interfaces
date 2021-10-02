using System;

namespace Interfaces
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period) : base(amount, period) { }

        public override decimal Income()
        {
            decimal result = 0;
            if (Period > 0)
            {
                result = Amount;
                for (int i = 0; i < Period; i++)
                {
                    result += 0.05m * result;
                }
                if (result > Amount)
                    return Math.Round(result - Amount, 2);
            }
            return result;
        }
    }
}
