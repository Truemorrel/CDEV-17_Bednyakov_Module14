using System;
using System.Linq;

namespace Task_14_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сделайте выборку в анонимный тип с одновременной сортировкой
            // слов по длине. Результат выведите в консоль.
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var lineupWords = words.Select(w => new
            {
                word = w,
                length = w.Length,
            }).OrderBy(wd => wd.length);
            foreach(var w in lineupWords)
            {
                Console.WriteLine(w.word);
            }
        }
    }
}
