using System;
namespace Students
{
    public class Group
    {
        //Fields
        private uint groupNumber;
        private string departmentName;

        //Constructor
        public Group(uint numberOfGroup, string nameOfDepartment)
        {
            this.groupNumber = numberOfGroup;
            this.departmentName = nameOfDepartment;
        }

        //Properties
        public uint GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Group number must be > 0!");
                }
                this.groupNumber = value;
            }
        }
        public string DepartmentName
        {
            get { return this.departmentName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You shoudl specify the name of the department!");
                }
                this.departmentName = value;
            }
        }

    }
}
