﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeChange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal price = new Random().Next(0, 100000) / 100m;
            Console.WriteLine($"The Calculated Price is: {price:C}");
            Change change = new Change(price);

            Console.WriteLine($"Hundred Dollar Bills: {change.HundredDollarBills}");
            Console.WriteLine($"Fifty Dollar Bills: {change.FiveDollarBills}");
            Console.WriteLine($"Twenty Dollar Bills: {change.TwentyDollarBills}");
            Console.WriteLine($"Ten Dollar Bills: {change.TenDollarBills}");
            Console.WriteLine($"Five Dollar Bills: {change.FiveDollarBills}");
            Console.WriteLine($"Dollar Bills: {change.DollarBills}");
            Console.WriteLine($"Quarters: {change.Quarters}");
            Console.WriteLine($"Dimes: {change.Dimes}");
            Console.WriteLine($"Nickels: {change.Nickels}");
            Console.WriteLine($"Pennies: {change.Pennies}");

            Console.ReadKey();
        }
        public class Change
        {

            public int HundredDollarBills { get; }
            public int FiftyDollarBills { get; }
            public int TwentyDollarBills { get; }
            public int TenDollarBills { get; }
            public int FiveDollarBills { get; }
            public int DollarBills { get; }
            public int Quarters { get; }
            public int Dimes { get; }
            public int Nickels { get; }
            public int Pennies { get; }

            public Change(decimal price)
            {
                HundredDollarBills = (int)(price / 100);
                price %= 100;

                FiftyDollarBills = (int)(price / 50);
                price %= 50;

                TwentyDollarBills = (int)(price / 20);
                price %= 20;

                TenDollarBills = (int)(price / 10);
                price %= 10;

                FiveDollarBills = (int)(price / 5);
                price %= 5;

                DollarBills = (int)(price / 1);
                price %= 1;

                Quarters = (int)(price / .25m);
                price %= .25m;

                Dimes = (int)(price / .10m);
                price %= .10m;

                Nickels = (int)(price / .05m);
                price %= .05m;

                Pennies = (int)(price / .01m);
            }
        }

    }
}
