using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    public class Student //Öğrenci sınıfı oluşturuldu.
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }

    public class Class // Sınıf(Ders) sınıfı oluşturuldu.
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
