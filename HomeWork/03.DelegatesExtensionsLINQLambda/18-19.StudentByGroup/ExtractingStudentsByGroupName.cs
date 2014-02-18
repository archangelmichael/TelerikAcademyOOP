using System;
using System.Linq;
namespace StudentByGroup
{
    /* 
     * Task 18
     * Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
     
     * Task 19
     * Rewrite the previous using extension methods.
     */
    public class ExtractingStudentsByGroupName
    {
        public static Student[] GenerateStudentArray()
        {
            string[] names = new string[] 
            {
                "Ivan", "Ivanka", "Maria", "Gosho", "Vladimir",
                "Dragomir", "Mitko", "Joro", "Kinka", "Tuturutka", 
                "Kiril", "Mitka", "Katq", "Vasil" 
            };

            string[] groups = new string[] 
            { 
                "Maths", "Biology", "Law", "ComputerScience", "RoketScience" ,
                "Physics", "Mythology", "Foreign Languages", "Culture"
            };

            Random generator = new Random();

            Student[] students = new Student[generator.Next(20, 31)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(names[generator.Next(0, names.Length)], groups[generator.Next(0, groups.Length)]);
            }

            return students;
        }

        public static void Main()
        {
            Student[] students = GenerateStudentArray();

            Console.WriteLine(new string('*', 25) + "Using LINQ!" + new string('*', 25));
            var orderedStudentsLinq = from st in students
                                      orderby st.GroupName
                                      select st;

            foreach (var student in orderedStudentsLinq)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('*', 25) + "Using Extension Methods!" + new string('*', 25));
            var orderedStudentsExtension = students.OrderByGroupName();

            foreach (var student in orderedStudentsExtension)
            {
                Console.WriteLine(student);
            }
        }
    }
}
