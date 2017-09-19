using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataGenerator
{
    class Generator
    {        

        static public List<Transaction> Generate(DateTime startDate, DateTime endDate, List<Rule> ruleset)
        {
            List<Transaction> transactions = new List<Transaction>();

            foreach (var rule in ruleset)
            {
                
                DateTime iterator = startDate;

                var random = new Random();

                while ((rule.StartDate == DateTime.MinValue || iterator > rule.StartDate)
                    && (rule.EndDate == DateTime.MinValue || iterator < rule.EndDate)
                    && iterator < endDate)
                {
                    if (1 - random.NextDouble() < rule.Chance)
                    {                        
                        transactions.Add(new Transaction
                        {
                            Amount = Math.Floor(rule.Base + (rule.Base * rule.Variation * (random.NextDouble() - 0.5))),
                            DateTime = iterator
                        });
                    }
                    iterator += rule.Span;
                }
            }

            return transactions.OrderBy(t => t.DateTime).ToList();
        }

    }
}
