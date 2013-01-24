﻿using System;

namespace Mike.Spikes.RefactoringExample
{
    public class DataAccess
    {
        public void Update(string customer, string color, DateTime endDate)
        {
            Console.Out.WriteLine("Update");
            Console.Out.WriteLine("customer = {0}", customer);
            Console.Out.WriteLine("color = {0}", color);
            Console.Out.WriteLine("endDate = {0}", endDate);
        }

        public void UpdateTemporaryStore(string customer, string color)
        {
            Console.Out.WriteLine("UpdateTemporaryStore");
            Console.Out.WriteLine("customer = {0}", customer);
            Console.Out.WriteLine("color = {0}", color);
        }
    }
}