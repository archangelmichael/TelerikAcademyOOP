using System;
namespace GSMInfo
{
    //Task 8
    public class Call   
    {
        //Fields
        private DateTime date;
        private DateTime time;
        private uint dialedNumber;  // when using ulong and uint we make sure there wont be an invalid input for them
        private ulong duration;

        // Constructor
        public Call(DateTime Date, DateTime Time, uint DialedPhoneNumber, ulong Duration)  
        {
            this.date = Date;
            this.time = Time;
            this.dialedNumber = DialedPhoneNumber;
            this.duration = Duration;
        }

        // Properties   only getters, cause this data should not be edited
        public DateTime Date
        {
            get { return this.date; }
        }
        public DateTime Time
        {
            get { return this.time; }
        }
        public uint DialedNumber
        {
            get { return this.dialedNumber; }
        }
        public ulong Duration
        {
            get { return this.duration; }
        }
    }
}
