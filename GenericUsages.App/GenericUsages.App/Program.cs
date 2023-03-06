using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericUsages.Library;
using GenericUsages.Library.GenericSort;

namespace GenericUsages.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();
            List<Teacher> teach = new List<Teacher>();
            Student student = new Student();
            Teacher teacher = new Teacher();
            stud.Add(new Student
            {
                Name = "Матвей",
                University = "ТвГТУ",
                Faculty = "ФПИЭ",
                StudingYears = 2,
                SumDebt = 0
            });
            stud.Add(new Student
            {
                Name = "Марина",
                University = "ТвГТУ",
                Faculty = "ФИТ",
                StudingYears = 6,
                SumDebt = 2
            });

            teach.Add(new Teacher
            {
                Name = "Чернигова Марина Ивановна",
                Degree = "Кандидат филологических наук",
                Positions = "Доцент",
                Workplace = "ТвГУ",
                Experience = 6,
                Phone = "89607183375",
                Idstud = { 0, 1, 2, 3 }
            });
            teach.Add(new Teacher
            {
                Name = "Увалов Александр Леонидович",
                Degree = "Доктор математических наук",
                Positions = "Декан",
                Workplace = "ТвГTУ",
                Experience = 16,
                Phone = "89607186375",
                Idstud = { 0, 2 }
            });
            teach.Add(new Teacher
            {
                Name = "Смирнова Елена Дмитриевна",
                Degree = "Кандидат педогогических наук",
                Positions = "Старший преподаватель",
                Workplace = "ТвГУ",
                Experience = 14,
                Phone = "89677193375"
            });
            GenericSort<Student> gen1 = new GenericSort<Student>();

            gen1.Sort(stud, student.CompareStudent);
            foreach (Student a in stud)
                Console.WriteLine(a);

            Console.WriteLine();

            GenericSort<Teacher> gen2 = new GenericSort<Teacher>();
            gen2.Sort(teach, teacher.CompareTeacher);
            foreach (Teacher a in teach) Console.WriteLine(a);
            Console.ReadKey();

            
        }
    }
}
