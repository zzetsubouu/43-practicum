using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    struct Student
    {
        public string fullName;
        public int group;
        public int informatics;
        public int physics;
        public int history;

        public Student(string fullName, int group, int informatics, int physics, int history)
        {
            this.fullName = fullName;
            this.group = group;
            this.informatics = informatics;
            this.physics = physics;
            this.history = history;
        }

        static public Student CreateStudent()
        {
            Console.WriteLine("введите фио");
            string fullName = Console.ReadLine();
            Console.WriteLine("введите группу");
            int group = int.Parse(Console.ReadLine());
            Console.WriteLine("введите оценку по информатике");
            int informatics = int.Parse(Console.ReadLine());
            Console.WriteLine("введите оценку по физике");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("введите оценку по истории");
            int history = int.Parse(Console.ReadLine());
            return new Student(fullName, group, informatics, physics, history);
        }
        public static double GetAverageGrade(Student student)
        {
            return (student.informatics + student.physics + student.history) / 3;
        }
    }
}
