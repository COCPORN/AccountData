using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = Generator.Generate(DateTime.Now.AddMonths(-7), DateTime.Now, new List<Rule>
            {
                new Rule
                {
                    Base = 45000,
                    Chance = 1,
                    Span = TimeSpan.FromDays(30),
                    Variation = .03f
                },
                new Rule
                {
                    Base = -9000,
                    Chance = 1,
                    Span = TimeSpan.FromDays(31)
                },
                new Rule
                {
                      Base = -2500,
                    Chance = 1,
                    Span = TimeSpan.FromDays(32)
                },
                new Rule
                {
                    Base = -30,
                    Chance = 0.5,
                    Span = TimeSpan.FromDays(1),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -45,
                    Chance = 0.5,
                    Span = TimeSpan.FromDays(1),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -90,
                    Chance = 0.5,
                    Span = TimeSpan.FromDays(1),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -230,
                    Chance = 0.5,
                    Span = TimeSpan.FromDays(1),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -1200,
                    Chance = 0.9,
                    Span = TimeSpan.FromDays(7),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -6000,
                    Chance = 0.04,
                    Span = TimeSpan.FromDays(1),
                    Variation = .9f
                },
                new Rule
                {
                    Base = -4000,
                    Chance = 0.5,
                    Span = TimeSpan.FromDays(2),
                    Variation = .5f
                }
            });

            System.IO.File.WriteAllText("output.json", JsonConvert.SerializeObject(transactions));
        }
    }
}
