namespace HumanStudentWorker
{
    using System;

    class Worker: Human
    {
        //Fields
        private decimal weekSalary;
        private decimal workHoursPerDay;
        private int workDaysPerWeek = 5;

        //Properties
        public decimal WeekSalary
        {
            get { return WeekSalary; }
            set { WeekSalary = value; }
        }
        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
        public int WorkDaysPerWeek
        {
            get { return workDaysPerWeek; }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException(" Invalid number of working days per week!");
                }
                workDaysPerWeek = value;
            }
        }

        //Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHourPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHourPerDay;
            this.workDaysPerWeek = 5;
        }

        //Methods
        public override string GetFirstName()
        {
            return this.FirstName;
        }
        public override string GetLastName()
        {
            return this.LastName;
        }
        public decimal MoneyPerHour() //returns money earned by hour by the worker
        {
            return this.weekSalary / this.workHoursPerDay / this.workDaysPerWeek;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} works for {2:C} per hour {3} hours in {4} days per week.",
                GetFirstName(), GetLastName(), this.MoneyPerHour(), this.workHoursPerDay, this.workDaysPerWeek);
        }
    }
}
