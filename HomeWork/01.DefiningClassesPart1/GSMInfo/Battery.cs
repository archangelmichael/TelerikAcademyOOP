namespace GSMInfo
{
    using System;
    // Enumeration Task 3
    public enum BatteryType
    {
        LiIon = 0,
        NiMH = 1, 
        NiCd = 2
    }
    public class Battery
    {
        // Fields Task 1
        private string batteryModel;
        private int? batteryHoursIdle;
        private int? batteryHoursTalk;
        private BatteryType typeOfBattery;  // Task 3

        // Constructors  Task 2
        public Battery() : this(null, null, null, BatteryType.LiIon)
        {
        }
        public Battery(string model) : this(model, null, null, BatteryType.LiIon)
        {
        }
        public Battery(string model, int? IdleHours, int? TalkHours, BatteryType batteryType)
        {
            this.batteryModel = model;
            if (TalkHours < 0)
            {
                throw new ArgumentException("Invalud battery talking hours capacity!");
            }
            else
            {
                this.batteryHoursTalk = TalkHours;
            }

            if (IdleHours < 0)
            {
                throw new ArgumentException("Invalud battery idle hours capacity!");
            }
            else
            {
                this.batteryHoursIdle = IdleHours;
            }
            this.typeOfBattery = batteryType;  // Task 3
        }

        //Properties  implement task 5
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public int? BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalud battery idle hours capacity!");
                }
                else
                {
                    this.batteryHoursIdle = value; 
                }
            }
        }
        public int? BatteryHoursTalk
        {
            get { return this.batteryHoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalud battery talking hours capacity!");
                }
                else
                {
                    this.batteryHoursTalk = value; 
                }
                
            }
        }
        public BatteryType TypeOfBattery   //Task 3
        {
            get { return this.typeOfBattery; }
            set { this.typeOfBattery = value; }
        }
        
    }
}
