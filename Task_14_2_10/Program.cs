using System;
using System.Linq;
using System.Collections.Generic;


namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                Console.Write("Введите номер страницы ");
                char input = Console.ReadKey().KeyChar;
                Console.Clear();
                if (!char.IsDigit(input))
                {
                    Console.WriteLine("Ошибка. Введите номер страницию.");
                    continue;
                };
                int page = Convert.ToInt32(input.ToString());
                int itemsOnPage = 2;
                IEnumerable<Contact> pageContacts = phoneBook.
                    Skip((page - 1) * itemsOnPage).
                    Take(itemsOnPage);
                if(pageContacts.Count() == 0)
                {
                    Console.WriteLine("Ошибка. Страница не существует.");
                    continue;
                };
                foreach (Contact contact in pageContacts)
                {
                    Console.WriteLine($"{contact.Name} {contact.LastName}: {contact.PhoneNumber}, {contact.Email}");
                };
             }
        }
    }
}