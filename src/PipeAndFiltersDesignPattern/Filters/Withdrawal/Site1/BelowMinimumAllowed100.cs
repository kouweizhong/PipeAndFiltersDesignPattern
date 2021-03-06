﻿
using PipeAndFiltersDesignPattern.Pipeline;

namespace PipeAndFiltersDesignPattern.Filters.Withdrawal.Site1
{
    public class BelowMinimumAllowed100 : IFinancialRule<DomainObjects.Withdrawal>
    {
        public void Execute(Context<DomainObjects.Withdrawal> context)
        {
            const int minimumAllowed = 100;

            if (context.item.Amount < minimumAllowed)
                context.Errors.Add("Withdrawal amount is less than minimum amount.");
        }
    }
}
