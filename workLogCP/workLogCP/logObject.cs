using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workLogCP
{
    public class LogObject
    {
        
        //declaring class objects
        private static double MinimumWage = 7.05;
        private static double HolidayRate = 1.1207;
        private double HourlyRate = MinimumWage * HolidayRate;

        public int LogEntryId { get; set; }
        public int HoursWorked { get; set; }
        public double ExpectedPay { get; set; }
        public double ActualPay { get; set; }
        
        public string WeekCommencing { get; set; }
        public string AdditionalNotes { get; set; }

        //constructor
        public LogObject(int _logEntryID, int _hours, string _weekCommencing, string _additionalNotes)
        {
            //assiging hours e.t.c
            this.LogEntryId = _logEntryID;
            this.HoursWorked = _hours;
            this.WeekCommencing = _weekCommencing;
            this.AdditionalNotes = _additionalNotes;

            //working out expected pay for week
            this.ExpectedPay = HoursWorked * HourlyRate;
        }



        

    }
}
