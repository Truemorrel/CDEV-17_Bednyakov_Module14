using System;
using System.Linq;

namespace Task_14_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
                "четыре пять шесть",
                "семь восемь девять" };
            var soloString = from Range in text
                             from w in Range.Split(new char[] { ' ' })
                             select w;
            foreach(string s in soloString)
            {
                Console.WriteLine(s);
            }
        }
    }
}
