using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    class StudentsList
    {
        List<Student> students = new List<Student>();
        List<Student> studentsWithMinGrade4 = new List<Student>();
        
        public void AddStudent(Student student) => students.Add(student);
        public void GetAllStudents()
        {
            Console.Clear();
            if (students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
                return;
            }
            Console.WriteLine("ФИО\tГРУППА\tБАЛЛ ПО ИНФОРМАТИКЕ\tБАЛЛ ПО ФИЗИКЕ\tБАЛЛ ПО ИСТОРИИ");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.fullName}\t{student.group}\t{student.informatics}\t{student.physics}\t{student.history}");
            }
        }
        public void GetStudentsWithMinimumGrade4()
        {
            Console.Clear();
            if (students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
                return;
            }
            studentsWithMinGrade4 = students.Where(s => Student.GetAverageGrade(s) >= 4).ToList();
            Console.WriteLine("Студенты с минимальной оценкой 4 и выше:");
            Console.WriteLine("ФИО\tГРУППА\tСРЕДНИЙ БАЛЛ ПО ПРЕДМЕТАМ");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.fullName}\t{Student.GetAverageGrade(student)}");
            }
            Console.WriteLine($"Количество студентов с минимальной оценкой 4 и выше:\n{studentsWithMinGrade4.Count()}");
        }
    }
}
