using System;
namespace GSMInfo
{
    public class GSMCallHistoryTest    //Task 12
    {
        static GSM historyTest = new GSM("Model Test 1", "Manufacturer Test 1");
        static Random rand = new Random();
        public static void GSMCallHistory(uint NumberOfTest)
        {
            if (NumberOfTest > 0)
            {
                //Generate random calls
                for (int index = 0; index < NumberOfTest; index++)
                {
                    Call call = new Call(DateTime.Now, DateTime.Now, 0888654345, (ulong)((index + 1) * rand.Next(1, 100)));
                    historyTest.AddCallInHistory(call);
                }

                // Print call history
                for (int index = 0; index < historyTest.CallHistory.Count; index++)
                {
                    Console.WriteLine("Call: {1} {0} Date: {2:MM/dd/yy} {0} Time: {3: H:mm:ss} {0} Phone Number: {4} {0} Duration: {5}",
                        Environment.NewLine,index + 1, historyTest.CallHistory[index].Date, historyTest.CallHistory[index].Time,
                        historyTest.CallHistory[index].DialedNumber, historyTest.CallHistory[index].Duration);
                }
                Console.WriteLine();

                // Get call price per minute
                Console.WriteLine("Enter call price per minute (in USD): ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Total call price :{0:C}", historyTest.CallPrice(price)));

                // Get the longest call from history
                ulong longestCallDuration = 0;
                Call longestCall = new Call(DateTime.Today, DateTime.Today, 0, 0);
                foreach (var item in historyTest.CallHistory)
                {
                    if (item.Duration >= longestCallDuration)
                    {
                        longestCall = item;
                    }
                }
                // Remove longest call from history
                historyTest.DeleteCallFromHistory(longestCall);

                // Final price for calls
                Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Final total call price :{0:C}", historyTest.CallPrice(price)));

                historyTest.ClearHistory();
                // Check if all hsitory has been deleted
                foreach (var item in historyTest.CallHistory)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Invalide Input!");
            }
        }
    }
}
