using System;
using System.Collections.Generic;
using System.Linq;
using Task_14_2_5.Model;

namespace Task_14_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };
            while(true)
            {
                char pageChar = Console.ReadKey().KeyChar;
                Console.Clear();
                if (!char.IsDigit(pageChar))
                {
                    Console.WriteLine("Ошибка. Введите номер страницы.");
                    continue;
                };
                IEnumerable<Contact> pageBook = null;

                int pageNum = Convert.ToInt32(pageChar.ToString());
                pageBook = contacts.Skip((pageNum - 1) * 2).Take(2);

                if (pageBook.Count() == 0)
                {
                    Console.WriteLine($"Страница {pageNum} не существует.");
                    continue;
                }
                foreach (Contact contact in pageBook)
                {
                    Console.WriteLine($"{contact.Name} : {contact.Phone}");
                }
            }
        }
    }
}
