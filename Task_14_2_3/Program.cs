using System;
using System.Collections.Generic;
using System.Linq;
using Task_14_2_3.Model;

namespace Task_14_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            var studentApplications = from student in students
                                      let birthYear = DateTime.Now.Year - student.Age
                                      select new Application()
                                      {
                                          Name = student.Name,
                                          YearOfBirth = birthYear,
                                      };

            foreach (var application in studentApplications)
            {
                Console.WriteLine($"{application.Name} : {application.YearOfBirth}");
            }
        }
    }
}
