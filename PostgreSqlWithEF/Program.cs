﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlWithEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new EFDbContext())
            {
                var cars = context.Cars.ToArray();
                Console.WriteLine($"We have {cars.Length} car(s).");
            }
        }
    }
}
