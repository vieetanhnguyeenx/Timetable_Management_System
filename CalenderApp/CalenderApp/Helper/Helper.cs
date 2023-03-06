using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalenderApp.Helper
{
    public static class Helper
    {
        public static string GetDayOfWeekByNumber(int dateOfWeek)
        {
            switch (dateOfWeek)
            {
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                case 8:
                    return "Sunday";
                default:
                    return "-1";
            }
        }

        public static int GetDayOfWeekByString(string dateOfWeek)
        {
            switch (dateOfWeek)
            {
                case "Monday":
                    return 2;
                case "Tuesday":
                    return 3;
                case "Wednesday":
                    return 4;
                case "Thursday":
                    return 5;
                case "Friday":
                    return 6;
                case "Saturday":
                    return 7;
                case "Sunday":
                    return 8;
                default:
                    return -1;
            }
        }

    }
}
