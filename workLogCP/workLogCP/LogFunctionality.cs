using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workLogCP
{
    class LogFunctionality
    {

        Program pr = new Program();

        /// <summary>
        /// Instructions and code to add a new LogEntry object
        /// </summary>
        public void AddLog()
        {
            
            Console.WriteLine("First enter the number of hours worked this week:");

            int HoursInt = 0;
            bool correctInt = false;

            while (correctInt == false)
            {
                try
                {
                    HoursInt = int.Parse(Console.ReadLine());
                    correctInt = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            Console.WriteLine("Please enter the Week's start date, (Monday) DD / MM / YYYY :");
            string weekStart = Console.ReadLine();

            Console.WriteLine("Lastly enter any additional notes:");
            string additionNotes = Console.ReadLine();

            //------------------------------------------------
            //To avoid 2 items having same number
            /*
             * if count > 0
             * get last index of list
             * get the id of item in last index
             * + 1 to id and save it as new item's id value.
             * */
            int nextId = 0;
            if (pr.listOfLogs.Count > 0)
            {
                nextId = pr.listOfLogs.Count + 1;
            }
            

            LogObject newLog = new LogObject(nextId, HoursInt, weekStart, additionNotes);

            pr.listOfLogs.Add(newLog);

        }


        /// <summary>
        /// Instructions and code to delete LogEntry Object
        /// </summary>
        public void DeleteLog()
        {
            foreach (LogObject a in pr.listOfLogs)
            {
                Console.WriteLine("Entry ID: " + a.LogEntryId.ToString() + ", Week commencing: " + a.WeekCommencing);
            }

            string itemToDelete = Console.ReadLine();
            int entryID = 0;
            bool correctInt = false;

            while (correctInt == false)
            {
                try
                {
                    entryID = int.Parse(itemToDelete);
                    correctInt = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                    itemToDelete = Console.ReadLine();
                }
            }

            foreach (LogObject a in pr.listOfLogs)
            {
                if (a.LogEntryId == entryID)
                {
                    Console.WriteLine("LogEntry: " + a.LogEntryId + ", Week Commencing: " + a.WeekCommencing + ". Deleted.");
                    pr.listOfLogs.Remove(a);
                    
                }
            }
        }


        /// <summary>
        /// Instructions and code to view LogEntry Object(s)
        /// </summary>
        public void ViewLog()
        {
            Console.WriteLine("Type the entry id you wish to view.");
            foreach (LogObject a in pr.listOfLogs)
            {
                Console.WriteLine("Entry ID: " + a.LogEntryId.ToString() + ", Week commencing: " + a.WeekCommencing);
            }

            string itemToDelete = Console.ReadLine();
            int entryID = 0;
            bool correctInt = false;

            while (correctInt == false)
            {
                try
                {
                    entryID = int.Parse(itemToDelete);
                    correctInt = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                    itemToDelete = Console.ReadLine();
                }
            }

            foreach (LogObject a in pr.listOfLogs)
            {
                if (a.LogEntryId == entryID)
                {
                    Console.WriteLine("LogEntry: " + a.LogEntryId + "\nWeek Commencing: " + a.WeekCommencing + "\nHours: " + a.HoursWorked + "\nExpected Pay: " + a.ExpectedPay + 
                        "\nActual Pay: " + a.ActualPay + "\nAdditional Notes: " + a.AdditionalNotes + "\n\n");
                }
            }
        }


        /// <summary>
        /// Instructions and code to edit logEntry object
        /// </summary>
        public void EditLog()
        {

        }
    }
}
