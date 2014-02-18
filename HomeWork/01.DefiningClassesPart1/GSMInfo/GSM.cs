namespace GSMInfo
{
    using System;
    using System.Collections.Generic;
    public class GSM  // internal by default
    {
        // Fields
        static GSM IPhone4s = new GSM("iPhone 4S", "Apple");   //Task 6
        // Task 1
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        public Battery Battery = new Battery();
        public Display Display = new Display();

        private static List<Call> callHistory = new List<Call>();   //Task 9

        // Constructors  Task 2
        // No default constructor here, cause model and manufacturer are obligatory
        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal? price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            if (price < 0)  // Task 5
            {
                throw new ArgumentException("Invalid price!");
            }
            else
            {
                this.price = price;
            }
            this.owner = owner;
        }

        //Properties    implement task 5
        public GSM IPhone4S  //Task 6
        {
            get { return IPhone4s; }
        }
        public List<Call> CallHistory  //Task 9
        {
            get 
            { 
                return callHistory; 
            }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set //Task 5
            {
                if (value < 0)  
                {
                    throw new ArgumentException("Invalid price!");
                }
                else
                {
                    this.price = value; 
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        //Methods
        public void AddCallInHistory(Call newCall)  //Task 10
        {
            callHistory.Add(newCall);
        }
        public bool DeleteCallFromHistory(Call call)  //Task 10
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Date == call.Date &&
                    callHistory[i].Time == call.Time &&
                    callHistory[i].DialedNumber == call.DialedNumber &&
                    callHistory[i].Duration == call.Duration)
                {
                    callHistory.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void ClearHistory()  //Task 10
        {
            callHistory.Clear();
        }
        public decimal CallPrice(decimal callPricePerMinute)  //Task 11
        {
            decimal sum = 0;
            foreach (var item in callHistory)
            {
                sum += (decimal)item.Duration;
            }
            return sum * callPricePerMinute;
        }
        public override string ToString()  // Task 4
        {
            var result = new List<string>();
            result.Add("Model: " + this.model);
            result.Add("Manufacturer: " + this.manufacturer);
            result.Add(string.Format(new System.Globalization.CultureInfo("en-US"), "Price :{0:C}", this.price));
            result.Add("Owner: "+ this.owner);
            result.Add("Battery Model: " + this.Battery.BatteryModel);
            result.Add("Battery type: " + this.Battery.TypeOfBattery.ToString());
            result.Add("Hours Idle: " + this.Battery.BatteryHoursIdle.ToString());
            result.Add("Hours Talk: " + this.Battery.BatteryHoursTalk.ToString());
            result.Add("Display Size (in inches): " + this.Display.Size.ToString());
            result.Add("Number of colors: " + this.Display.NumberOfColors.ToString());

            return string.Join(Environment.NewLine,result); 
        }
    }
}
