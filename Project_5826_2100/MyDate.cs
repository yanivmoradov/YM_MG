using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    /// <summary>
    /// date with day, month and year
    /// </summary>
    class MyDate
    {
        private int day;
        private int month;
        private int year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        /// <summary>
        /// Returns a string that represents the MyDate.
        /// </summary>
        /// <returns>string that represents the MyDate.</returns>
        public override string ToString()
        {
            return Day + "." + Month + "." + Year;
        }
    }
}
