namespace Students
{
    /*
     * Task 9
     * Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
     * Create a List<Student> with sample students. 
     * Select only the students that are from group number 2. 
     * Use LINQ query. Order the students by FirstName.

     * Task 10
     * Implement the previous using the same query expressed with extension methods.

     * Task 11
     * Extract all students that have email in abv.bg. Use string methods and LINQ.

     * * Task 12
     * Extract all students with phones in Sofia. Use LINQ.

     * Task 13
     * Select all students that have at least one mark Excellent (6) 
     * into a new anonymous class that has properties – FullName and Marks. Use LINQ.

     * Task 14
     * Write down a similar program that extracts the students with exactly  two marks "2". 
     * Use extension methods.

     * Task 15
     * Extract all Marks of the students that enrolled in 2006. 
     * (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

     * Task 16*
     * Create a class Group with properties GroupNumber and DepartmentName. 
     * Introduce a property Group in the Student class. 
     * Extract all students from "Mathematics" department. Use the Join operator.
     */
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsMain
    {
        public static List<Student> listOfStudents = new List<Student>()
            {
                new Student("Bobi", "Turboto", "23361406","0299923499", "bobi@abv.bg", 2,2, 2, 2, 5, 4, 1),
                new Student("Genka", "Shikerova", "11221105", "+359212345123", "wholetthedogsout@gbg.bg", 2,1, 1, 1, 1),
                new Student("Gosho", "Trankarq", "23361406","+359877223444", "whatisthis@abv.bg", 2,6, 6, 6, 3),
                new Student("Kata", "Mincheva", "12340608","+359874334144", "tellmeasecret@gmail.bg", 3, 6, 6, 6, 4, 6, 1),
                new Student("Mincho", "Praznikov", "82123444","07333441114", "whereareyou@abv.bg", 3,2, 2,3,4),
                new Student("Zakojto", "Sesetish", "14514506","+359215554442", "kajichesno@abv.bg", 2,6, 6, 6, 4, 6, 1),
                new Student("Kate", "Dobreva", "12340608","+359874235542", "biftek@gmail.bg", 3, 2, 2, 3, 4, 3, 1)
            };

        public static void Main()
        {
            // UNCOMMENT THE TASK YOU WANT TO CHECK

            Console.WriteLine(" Task 9 ".PadLeft(20));
            //Task9();

            Console.WriteLine(" Task 10 ".PadLeft(20));
            //Task10();

            Console.WriteLine(" Task 11 ".PadLeft(20));
            //Task11();

            Console.WriteLine(" Task 12 ".PadLeft(20));
            //Task12();

            Console.WriteLine(" Task 13 ".PadLeft(20));
            //Task13();

            Console.WriteLine(" Task 14 ".PadLeft(20));
            //Task14();

            Console.WriteLine(" Task 15 ".PadLeft(20));
            //Task15();

            Console.WriteLine(" Task 16 ".PadLeft(20));
            //Task16();

        }

        //Methods
        private static void Task9()
        {
            var studentsFromGroup2 =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        private static void Task10()
        {
            List<Student> studentsFromGroup2 = listOfStudents.GetStudentsInExactGroup(2);
            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        private static void Task11()
        {
            var allABVUsers =
                from student in listOfStudents
                where student.Email.Substring(student.Email.LastIndexOf("@")) == "@abv.bg"
                select student;
            foreach (var student in allABVUsers)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        private static void Task12()
        {
            var allStudentsWithSofiaPhoneNumbers =
                from student in listOfStudents
                where student.Tel.StartsWith("+3592") || student.Tel.StartsWith("02")
                select student;
            foreach (var student in allStudentsWithSofiaPhoneNumbers)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        private static void Task13()
        {
            var studentsWithAtLeastOneExcellent = 
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new
                     {
                        StudentName = string.Format("{0} {1}", student.FirstName, student.LastName),
                        Marks = student.Marks
                     };
            foreach (var student in studentsWithAtLeastOneExcellent)
            {
                Console.WriteLine(student.StudentName + "'s marks: " + string.Join(", ", student.Marks));
            }
            Console.WriteLine();
        }

        private static void Task14()
        {
            List<Student> studentsWithExactMarks = listOfStudents.GetStudentWithNumberOfSpecificMark(2,2);
            foreach (var student in studentsWithExactMarks)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        private static void Task15()
        {
            var MarksFromStudentsEnrolledIn2006 =
                from student in listOfStudents
                where student.FN.Substring(4, 2) == "06"
                select student.Marks;

            List<int> marks = new List<int>();

            foreach (var mark in MarksFromStudentsEnrolledIn2006)
            {
                marks.AddRange(mark);
            }

            Console.WriteLine(string.Join(", ", marks));
            Console.WriteLine();
        }

        private static void Task16()
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Mathematics"),
                new Group(3, "Maths"),
                new Group(4, "Computer Science"),
                new Group(5, "Medicine"),
                new Group(6, "Biology"),
            };

            var studentsFromGroupMathematics =
                from student in listOfStudents
                join groupOf in groups on student.GroupNumber equals groupOf.GroupNumber
                where groupOf.DepartmentName == "Mathematics"
                select student;

            foreach (var student in studentsFromGroupMathematics)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            
        }
    }
}
