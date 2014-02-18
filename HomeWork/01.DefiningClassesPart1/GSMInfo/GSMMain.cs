﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// All task in one solution due to common classes and information
// All classes in separate .cs files
#region Task 1
/* Define a class that holds information about a mobile phone device:
 * model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
 * and display characteristics (size and number of colors). 
 * Define 3 separate classes (class GSM holding instances of the classes Battery and Display).*/
#endregion

#region Task 2
/* Define several constructors for the defined classes that take different sets of arguments
 * (the full information for the class or part of it). 
 * Assume that model and manufacturer are mandatory (the others are optional). 
 * All unknown data fill with null.*/

// I use '?' operator to enable null values for all fields
#endregion

#region Taks 3
// Implemented in Class Battery
/* Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.*/
#endregion

#region Task 4
// Implemented in Class GSM
/* Add a method in the GSM class for displaying all information about it. Try to override ToString().*/
#endregion

#region Task 5
// Implemented in general by using private fields and properties for them
/* Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
* Ensure all fields hold correct data at any given time.*/
#endregion

#region Task 6
/* Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.*/
#endregion

#region Task 7
/* Write a class GSMTest to test the GSM class:
 * Create an array of few instances of the GSM class.
 * Display the information about the GSMs in the array.
 * Display the information about the static property IPhone4S.*/
#endregion

#region Task 8
// implemented in Class Call
/* Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).*/
#endregion

#region Task 9
// implemented in Class GSM
/* Add a property CallHistory in the GSM class to hold a list of the performed calls.
* Try to use the system class List<Call>.*/
#endregion

#region Task 10
/* Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.*/
#endregion

#region Task 11
/* Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.*/
#endregion

#region Task 12
/* Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.
*/
#endregion


namespace GSMInfo
{
    public class GSMMain
    {
        static void Main(string[] args)
        {
            try
            {
                // Set number of test to be performed
                Console.WriteLine("Enter number of tests to perform: ");
                int numberOfTests = int.Parse(Console.ReadLine());
                // To test Class GSM using the method TestClassGSM
                GSMTest.TestClassGSM(numberOfTests);
                Console.WriteLine();
                // To test Class GSMCallHistoryTest using the method TestClassGSM
                GSMCallHistoryTest.GSMCallHistory((uint)numberOfTests);

                // To test override method of GSM ToString() uncomment next rows  (Task 4)
                /*
                GSM gsm = new GSM("IPhone 4S", "Apple", 700m, "Me");
                gsm.Battery = new Battery("PowerVR SGX543MP2", 200, 8, BatteryType.LiIon);
                gsm.Display = new Display(3.5, 3145728);
                Console.WriteLine(gsm.ToString());
                */
                // To test static field for iPhone 4s uncomment next row  (Task 6)
                // Console.WriteLine(gsm.IPhone4S.Model);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }
    }
}
