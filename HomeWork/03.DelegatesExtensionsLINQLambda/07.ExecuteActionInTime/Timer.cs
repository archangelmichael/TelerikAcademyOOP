namespace ExecuteActionInTime
{
    /*
     * Task 7
     * Using delegates write a class Timer that can execute certain method at each t seconds.
     */
    using System;
    using System.Threading;

    public delegate void TimerEvent();

    class Timer
    {
        //Fields
        private int ticks;
        private int interval;
        private int count;
        private TimerEvent timeEvent;

        //Constructors
        public Timer(int count, int interval, TimerEvent timerEvent) //with thicks and interval in seconds
        {
            this.count = count;
            this.interval = interval;
            this.timeEvent = timerEvent;
        }
        public Timer(int interval, TimerEvent TE)
            : this(int.MaxValue, interval, TE) { } //only interval in seconds and max thicks
        public Timer(TimerEvent TE)
            : this(int.MaxValue, 10000, TE) { } //max thicks and 10 second interval

        //Properties
        public int Interval
        {
            get
            {
                return this.interval;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be > 0 !");
                }
                this.interval = value * 1000;
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Count must be > 0 !");
                }
                this.count = value;
            }
        }

        //Methods
        private static void ExecuteEach3Seconds()
        {
            Console.WriteLine("Every 3rd second!");
        }
        private static void SecondExecuteEach5Seconds()
        {
            Console.WriteLine("Every 5th second!");
        }
        public void Run()
        {
            while (ticks < this.count)
            {
                Thread.Sleep(this.Interval);
                ticks++;
                timeEvent();
            }
        }

        static void Main()
        {
            TimerEvent timer3Seconds = new TimerEvent(ExecuteEach3Seconds);
            Timer timer1 = new Timer(3000, timer3Seconds);

            TimerEvent timer5Seconds = new TimerEvent(SecondExecuteEach5Seconds);
            Timer timer2 = new Timer(5000, timer5Seconds);

            Timer timer3 = new Timer(new TimerEvent(delegate() { Console.WriteLine("BIGTIME 10 seconds"); }));

            Thread timer1Thread = new Thread(new ThreadStart(timer1.Run));
            timer1Thread.Start();

            Thread timer2Thread = new Thread(new ThreadStart(timer2.Run));
            timer2Thread.Start();

            Thread timer3Thread = new Thread(new ThreadStart(timer3.Run));
            timer3Thread.Start();
        }
    }
}
