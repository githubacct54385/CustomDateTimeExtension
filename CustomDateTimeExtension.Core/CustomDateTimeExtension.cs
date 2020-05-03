using System;

namespace CustomDateTimeExtension {
    public static class CustomDateTimeExtension {
        public static string CustomToString (this DateTime date, bool hasTime) {
            string suffix = DayWordSuffix (date);
            int year = date.Year;
            string month = date.ToString ("MMMM");
            string dayofWeek = date.DayOfWeek.ToString ();
            string day = FormatDay (date.ToString ("dd"));
            string hour = date.ToString ("hh");
            string minute = date.ToString ("mm");
            string second = date.ToString ("ss");
            string amPm = date.ToString ("tt");

            return hasTime ? $"{dayofWeek} {month} {day}{suffix}, {year} {hour}:{minute}:{second} {amPm}" : $"{dayofWeek} {month} {day}{suffix}, {year}";
        }

        private static string FormatDay (string dayString) {
            int day = int.Parse (dayString);
            return day.ToString ();
        }

        private static string DayWordSuffix (DateTime date) {
            switch (date.Day) {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
        }
    }
}