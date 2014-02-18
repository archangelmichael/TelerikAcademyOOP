namespace SchoolMembers
{
/* 
     * Task 1.
     * We are given a school. In the school there are classes of students. 
     * Each class has a set of teachers. 
     * Each teacher teaches a set of disciplines. 
     * Students have name and unique class number.
     * Classes have unique text identifier. 
     * Teachers have studentName.
     * Disciplines have studentName, number of lectures and number of exercises. 
     * Both teachers and students are people. 
     * Students, classes, teachers and disciplines could have optional comments (free text block).
     * 
	 * Your task is to identify the classes (in terms of  OOP) 
     * and their attributes and operations, encapsulate their fields, 
     * define the class hierarchy and create a class diagram with Visual Studio.
*/

    using System.Collections.Generic;

    public class School
    {
        //Fields
        private string name;
        private List<ClassOfStudents> classes;

        //Properties
        public string Name { get; set; }

        //Constructors
        public School(string schoolName)
        {
            this.classes = new List<ClassOfStudents>();
            this.Name = schoolName;
        }
        public void AddClass(ClassOfStudents classToAdd)
        {
            classes.Add(classToAdd);
        }
    }
}
