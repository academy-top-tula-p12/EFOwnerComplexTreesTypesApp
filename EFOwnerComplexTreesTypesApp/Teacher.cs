//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EFOwnerComplexTreesTypesApp
//{
//    public class Book
//    {
//        public int Id { get; set; }
//        public string Title { get; set; } = null!;
//        public required Teacher Teacher { get; set; }
//    }

//    public class Modul
//    {
//        public int Id { get; set; }
//        public string Title { get; set; } = null!;
//        public required Teacher Teacher { get; set; }
//    }

//    //[ComplexType]
//    public class Teacher
//    {
//        public int Id { get; set; }
//        public string Name { get; set; } = null!;
//    }

//    public class ComplexExample
//    {
//        public static void Example()
//        {
//            using (HrDbContext context = new())
//            {
//                context.Database.EnsureDeleted();
//                context.Database.EnsureCreated();

//                //Country russia = new()
//                //{
//                //    Title = "Russia"
//                //};

//                //Country usa = new()
//                //{
//                //    Title = "Usa"
//                //};

//                //Company google = new()
//                //{
//                //    Title = "Google",
//                //    Country = usa
//                //};

//                //Employee bobby = new()
//                //{
//                //    Name = "Bobby",
//                //    Age = 24,
//                //    EmployeeInfo = new() 
//                //    { 
//                //        PassportSeries = "XI78",
//                //        PassportNumber = 123456
//                //    },
//                //    Country = russia,
//                //    Company = google
//                //};

//                //Employee jimmy = new()
//                //{
//                //    Name = "Jimmy",
//                //    Age = 35,
//                //    EmployeeInfo = new()
//                //    {
//                //        PassportSeries = "Y32A",
//                //        PassportNumber = 567321
//                //    },
//                //    Country = russia,
//                //    Company = google
//                //};

//                //context.Employees.AddRange(bobby, jimmy);

//                Teacher jonny = new Teacher() { Name = "Jonny" };
//                Teacher billy = new Teacher() { Name = "Billy" };

//                Book book1 = new() { Title = "Book 1", Teacher = jonny };
//                Book book2 = new() { Title = "Book 2", Teacher = billy };
//                Book book3 = new() { Title = "Book 3", Teacher = jonny };

//                Modul modul1 = new() { Title = "JavaScript", Teacher = billy };
//                Modul modul2 = new() { Title = "C#", Teacher = jonny };
//                Modul modul3 = new() { Title = "Php", Teacher = billy };

//                context.Books.AddRange(book1, book2, book3);
//                context.Modules.AddRange(modul1, modul2, modul3);

//                context.SaveChanges();


//                var books = context.Books.ToList();
//                var modules = context.Modules.ToList();

//                foreach (var m in modules)
//                    Console.WriteLine($"{m.Title} {m.Teacher.Name}");
//                Console.WriteLine();

//                foreach (var b in books)
//                    Console.WriteLine($"{b.Title} {b.Teacher.Name}");
//                Console.WriteLine();

//                var book = context.Books.FirstOrDefault();
//                if (book is not null) book.Teacher.Name = "Sammy";

//                books = context.Books.ToList();
//                modules = context.Modules.ToList();

//                foreach (var m in modules)
//                    Console.WriteLine($"{m.Title} {m.Teacher.Name}");
//                Console.WriteLine();

//                foreach (var b in books)
//                    Console.WriteLine($"{b.Title} {b.Teacher.Name}");
//                Console.WriteLine();
//            }

//            using (HrDbContext context = new())
//            {
//                //var books = context.Books.ToList();
//                //var modules = context.Modules.ToList();

//                //foreach(var m in modules)
//                //    Console.WriteLine($"{m.Title} {m.Teacher.Name}");
//                //Console.WriteLine();

//                //foreach (var b in books)
//                //    Console.WriteLine($"{b.Title} {b.Teacher.Name}");
//                //Console.WriteLine();

//                //var book = context.Books.FirstOrDefault();
//                //if (book is not null) book.Teacher.Name = "Sammy";
//                //Teacher teacher = context.Books.FirstOrDefault().Teacher;
//                //teacher.Name = "Sammy";
//                //context.SaveChanges();

//                //books = context.Books.ToList();
//                //modules = context.Modules.ToList();

//                //foreach (var m in modules)
//                //    Console.WriteLine($"{m.Title} {m.Teacher.Name}");
//                //Console.WriteLine();

//                //foreach (var b in books)
//                //    Console.WriteLine($"{b.Title} {b.Teacher.Name}");
//                //Console.WriteLine();


//            }
//        }
//    }
//}
