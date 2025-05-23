using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    /// <summary>
    /// описать структуру с полями фио,группа, информатика,физика, история.
    /// создать массив или коллекцию из N объектов данной структуры.
    /// ввод данныых осуществлять с клавиатуры.
    /// сведения об объекте вынести в табличном виде.
    /// в случае отуствии инфы об объекте ваывести соответсвующее собщение.
    /// 
    /// задача:
    /// определить средний балл оценок по каждому предмету.s
    /// вывести сведения о студентах, средний балл которых выше 4 и указать их количество.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList studentsList = new StudentsList();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Показать всех студентов");
                Console.WriteLine("3. Показать студентов с минимальной оценкой 4 и выше");
                Console.WriteLine("4. Выход");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var newStudent = Student.CreateStudent();
                        studentsList.AddStudent(newStudent);
                        Console.WriteLine("Студент добавлен.");
                        break;

                    case 2:
                        studentsList.GetAllStudents();
                        break;

                    case 3:
                        studentsList.GetStudentsWithMinimumGrade4();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
