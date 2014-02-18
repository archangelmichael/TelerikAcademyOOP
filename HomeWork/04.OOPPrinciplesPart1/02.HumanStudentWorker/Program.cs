namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    /*
     * Task 2
     * Define abstract class Human with first name and last name. 
     * Define new class Student which is derived from Human and has new field – grade. 
     * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
     * and method MoneyPerHour() that returns money earned by hour by the worker. 
     * Define the proper constructors and properties for this hierarchy. 
     * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
     * Initialize a list of 10 workers and sort them by money per hour in descending order. 
     * Merge the lists and sort them by first name and last name.
    */

    class Program
    {

        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Pesho","Peshev",3),
                new Student("Ivan", "Mitkov", 11),
                new Student("Dimitar", "Peshev", 5),
                new Student("Gosho", "Ivanov", 7),
                new Student("Petio", "Peshev", 12),
                new Student("Dragan", "Petkanov", 11),
                new Student("Asen", "Peshev", 8),
                new Student("Asen", "Apeshev", 8),
                new Student("Petkan", "Beshev", 10),
                new Student("Pesho", "Zeshev", 10)
            };

            //Sort students in ascending order by grade
            var orderedByGrade = listOfStudents.OrderBy( x => x.Grade).ThenBy(x => x.GetFirstName()).ThenBy(x => x.GetLastName());
            Console.WriteLine(new string('*', 15) + "Print ordered students by grade! " + new string('*', 15));
            foreach (var student in orderedByGrade)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("Ivan", "Peshev", 123.60m, 8),
                new Worker("Pesho", "Ivanov", 170.10m, 13),
                new Worker("Mitko", "Petkov", 145m, 8),
                new Worker("Strahil", "Ivanov", 201.49m, 10),
                new Worker("Dimitar", "Kolev", 121.60m, 6),
                new Worker("Ivan", "Nikolaev", 150.65m, 8),
                new Worker("Nikolai", "Ivanov", 183.70m, 9),
                new Worker("Krasi", "Ivanov", 90.60m, 8),
                new Worker("Joro", "Krasimirov", 303.90m, 14),
                new Worker("Asencho", "Asenov", 103.60m, 5),
            };

            //Sort workers by payment per hour
            var sortedListOfWorkersByMoneyPerHour = listOfWorkers.OrderBy(x => x.MoneyPerHour());
            Console.WriteLine(new string('*', 15) + "Print ordered workers by salary per hour! " + new string('*', 15));
            foreach (var worker in sortedListOfWorkersByMoneyPerHour)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();

            //Merge both lists
            var mergedPeople = new List<Human>(listOfStudents.Concat<Human>(listOfWorkers));

            //Order merged list by names
            var sortedPeople = mergedPeople.OrderBy(x => x.GetFirstName()).ThenBy(x => x.GetLastName());
            Console.WriteLine(new string('*', 15) + "Print ordered people by names! " + new string('*', 15));
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.GetFirstName() + " " + person.GetLastName());
            }
        }
    }
}
