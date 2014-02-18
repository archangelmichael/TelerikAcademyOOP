using System.Collections.Generic;
using System.Linq;
namespace Students
{
    public static class Extensions
    {
        public static List<Student> GetStudentsInExactGroup(this List<Student> students, int groupNumber)
        {
            IOrderedEnumerable<Student> StudentsInAGroup = 
                from student in students
                where student.GroupNumber == groupNumber
                orderby student.FirstName, student.LastName
                select student;
            return StudentsInAGroup.ToList();
        }
        public static List<Student> GetStudentWithNumberOfSpecificMark(this List<Student> students, int mark, int count)
        {
            var StudentsWithNumberOfSpecificMark =
                from student in students
                where student.Marks.Count(x => x == mark) == count
                orderby student.FirstName, student.LastName
                select student;
            return StudentsWithNumberOfSpecificMark.ToList();
        }

    }
}
