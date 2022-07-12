using System;
using System.Collections.Generic;

namespace Task_14_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // выбрать имена на букву А и отсортировать в алфавитном порядке.
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
            SortedSet<string> aName = new SortedSet<string>(people);
            aName.RemoveWhere( n => !n.ToUpper().StartsWith('А'));
            foreach (var item in aName)
            { 
                Console.WriteLine(item);
            };
         }
    }
}
