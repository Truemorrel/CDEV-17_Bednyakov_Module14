using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_14_1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей ",
                "Андрей ",
                300,
            };
            foreach (var s in objects.OrderBy(n => (n is string) ? n : Convert.ToString(n)))
                Console.WriteLine(s);
        }
    }
}
