using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period) { }

        public bool CanToProlong()
        {
            return (Amount > 1000);
        }

        public override decimal Income()
        {
            decimal result = 0;
            if (Period > 0)
            {
                result = Amount;
                for (int i = 0; i < Period; i++)
                {
                    result += ((i + 1) * 0.01m * result);
                }
                if (result > Amount)
                    return Math.Round(result - Amount, 2);
            }
            return result;
        }
    }
}
