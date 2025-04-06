using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseCalculator.Model
{
    public class State
    {
        public string Name { get; set; }
        public decimal TaxRate { get; set; }

        private State(string name, decimal taxRate)
        {
            Name = name;
            TaxRate = taxRate;
        }

        public static readonly State California = new State("California", 0.08m);
        public static readonly State Texas = new State("Texas", 0.08m);
        public static readonly State NewYork = new State("New York", 0.08m);
        public static readonly State Florida = new State("Florida", 0.08m);

        public static readonly State Washington = new State("Washington", 0.05m);
        public static readonly State Oregon = new State("Oregon", 0.05m);
        public static readonly State Idaho = new State("Idaho", 0.05m);
        public static readonly State Utah = new State("Utah", 0.05m);
        public static readonly State Montana = new State("Montana", 0.05m);
        public static readonly State NewMexico = new State("New Mexico", 0.05m);
        public static readonly State Arizona = new State("Arizona", 0.05m);
        public static readonly State Wyoming = new State("Wyoming", 0.05m);
        public static readonly State Kansas = new State("Kansas", 0.05m);
        public static readonly State Arkansas = new State("Arkansas", 0.05m);
        public static readonly State Georgia = new State("Georgia", 0.05m);
        public static readonly State Alabama = new State("Alabama", 0.05m);
        public static readonly State Lousiana = new State("Lousiana", 0.05m);

        public static readonly State Alaska = new State("Alaska", 0.00m);
        public static readonly State Colorado = new State("Colorado", 0.00m);
        public static readonly State Delaware = new State("Delaware", 0.00m);
        public static readonly State Nevada = new State("Nevada", 0.00m);
        public static readonly State NewJersey = new State("New Jersey", 0.00m);
        public static readonly State NorthCarolina = new State("North Carolina", 0.00m);
        public static readonly State Ohio = new State("Ohio", 0.00m);
        public static readonly State WashingtonDC = new State("Washington D.C", 0.00m);

        public static readonly State[] All = new[] {
            California, Texas, NewYork, Florida,
            Washington, Oregon, Idaho, Utah, Montana, NewMexico, Arizona, Wyoming, Kansas, Arkansas, Georgia, Alabama, Lousiana,
            Alaska, Colorado, Delaware, Nevada, NewJersey, NorthCarolina, Ohio, WashingtonDC
        };
    }
}
