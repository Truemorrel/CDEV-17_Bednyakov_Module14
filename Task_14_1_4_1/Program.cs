using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_14_1_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // выбрать имена на букву А и отсортировать в алфавитном порядке.
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var selctedPeople = from p in people
                                where p.StartsWith("А")
                                orderby p
                                select p;

            foreach (var item in selctedPeople)
            {
                Console.WriteLine(item);
            };
        }
    }
}
