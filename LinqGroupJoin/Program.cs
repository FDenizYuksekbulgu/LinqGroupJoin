using System;
using System.Collections.Generic;
using System.Linq;
using LinqGroupJoin;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student> //Verilen bilgilere göre öğrenciler listesi oluşturuldu.

        {
            new Student { StudentId = 1, StudentName = "Ali",     ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe",    ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet",  ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Fatma",   ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Ahmet",   ClassId = 2 }

        };


        List<Class> classes = new List<Class> //Verilen bilgilere göre sınıflar(dersler) listesi oluşturuldu.

        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };
        //'Group Join' kullanarak sınıflara ait öğrencileri gruplayalım.
        var classWithStudents = from c in classes
                                join s in students on c.ClassId equals s.ClassId into studentGroup
                                select new
                                {
                                    ClassName = c.ClassName, //Sınıfın isimleri buradan gelecek.
                                    Students = studentGroup //Bu sınıfa ait öğrencileri grupça bulacak.
                                };

        //Sonuçları ekrana yazdıralım.

        foreach (var item in classWithStudents)
        {
            Console.WriteLine($"Sınıf: {item.ClassName}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($"   {student.StudentName}");
            }
        }
    }
}