using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LongDeposit : Deposit, IProlongable
    {
        public LongDeposit(decimal amount, int period) : base(amount, period) { }

        public override decimal Income()
        {
            decimal result = 0;
            if (Period > 0)
            {
                result = Amount;
                for (int i = 0; i < Period; i++)
                {
                    if (i > 5)
                        result += 0.15m * result;
                }
                if (result > Amount)
                    return Math.Round(result - Amount, 2);
                else return 0;
            }
            return result;
        }
        public bool CanToProlong()
        {
            return (Period <= 3 * 12);
        }
    }
}
