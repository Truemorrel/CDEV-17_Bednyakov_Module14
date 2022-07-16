using System;
using System.Collections.Generic;
using System.Linq;
using Task_14_2_4.Model;

namespace Task_14_2_4
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

            // Список курсов
            var coarses = new List<Coarse>
            {
               new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
               new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };
            var studentApplications = from student in students
                                      where student.Age < 29
                                      where student.Languages.Contains("Английский".ToLower())
                                      let birthYear = DateTime.Now.Year - student.Age
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#")
                                      select new 
                                      {
                                          Name = student.Name,
                                          YearOfBirth = birthYear,
                                          coarse = coarse.Name,
                                      };

            foreach (var application in studentApplications)
            {
                Console.WriteLine($"{application.Name} : {application.YearOfBirth} : {application.coarse}");
            }
        }
    }
}
