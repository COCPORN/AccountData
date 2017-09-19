using System;

namespace AccountDataGenerator
{
    public class Rule
    {

        public double Chance { get; set; } = 1;

        public double Base { get; set; }

        public double Variation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan Span { get; set; }        
    }
}