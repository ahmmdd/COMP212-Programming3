﻿//an example of custom-made event
using System;

namespace W02_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(10);
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(Object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }

}