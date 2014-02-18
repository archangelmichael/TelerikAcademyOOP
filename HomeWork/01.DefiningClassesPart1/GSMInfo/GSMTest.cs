using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMInfo
{
    public class GSMTest   // Task 7
    {
        public static void TestClassGSM(int tests)
        {
            GSM[] myGSMs = new GSM[tests];
            // Generate several GSM objects
            for (int index = 0; index < myGSMs.Length; index++)
            {
                myGSMs[index] = new GSM("Model Test " + (index + 1), "Manufacturer Test " + (index + 1), ((index + 1) * 50), "Owner Test " + (index + 1));
                myGSMs[index].Display = new Display((index + 1) * 10, (index + 1) * 55);
                myGSMs[index].Battery = new Battery("Battery Test " + (index + 1), (index + 1) * 60, (index + 1) * 123, BatteryType.NiCd);
                Console.WriteLine(myGSMs[index]);
                Console.WriteLine();
            }

            // test static field IPhone4S
            GSM myIPhone = new GSM("", "");
            Console.WriteLine(myIPhone.IPhone4S);
        }

        
    }
}
