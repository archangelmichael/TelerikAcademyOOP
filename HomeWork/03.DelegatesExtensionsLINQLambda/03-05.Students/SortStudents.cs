namespace Students
{
    /*
     * Task 3.
     * Write a method that from a given array of students finds all students 
     * whose first name is before its last name alphabetically. 
     * Use LINQ query operators.
     * 
     * Task 4.
     * Write a LINQ query that finds the first name and last name 
     * of all students with age between 18 and 24.
     * 
     * Task 5.
     * Using the extension methods OrderBy() and ThenBy() with lambda expressions 
     * sort the students by first name and last name in descending order. 
     * Rewrite the same with LINQ.
     */
    using System;
    using System.Linq;

    struct Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }

    class SortStudents
    {

        static void Main()
        {
            var arrayOfStudents = new Student[]
            {
                new Student("pesho","peshev",21),
                new Student("maria","petkova",34),
                new Student("pesho","stoqnov",54),
                new Student("sonq","kolqnova",23),
                new Student("polq","pesheva",12),
                new Student("pesho","petrov",20),
                new Student("ivan","toshev",43),
                new Student("gosho","peshev",33),
                new Student("dragan","kirov",18),
                new Student("maria","paraskeva",24),
            };

            //Task 3
            var firstNameBeforeLast =
                from student in arrayOfStudents
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("First Name is before Last Name alphabetically : ");
            foreach (var item in firstNameBeforeLast)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //Task 4
            var withAgeBetween18And24 =
                from student in arrayOfStudents
                where student.Age>=18 && student.Age<=24
                select new Tuple<string, string>(student.FirstName,student.LastName);

            Console.WriteLine("Age is between 18 and 24 including: ");
            foreach (var item in withAgeBetween18And24)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }


            //Task 5
            var orderedInDescending = arrayOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine("Ordered by names in descending order: ");
            foreach (var item in orderedInDescending)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            var descendingOrderWithLINQ =
                from student in arrayOfStudents
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine("Ordered by names in descending order with LINQ: ");
            foreach (var item in descendingOrderWithLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
