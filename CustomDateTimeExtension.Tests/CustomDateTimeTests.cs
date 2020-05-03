using System;
using CustomDateTimeExtension.Core;
using Xunit;

namespace CustomDateTimeExtension.Tests {
    public class CustomDateTimeTests {
        [Theory]
        [InlineData ("Friday May 1st, 2020 12:00:00 AM", 2020, 5, 1)]
        [InlineData ("Saturday May 2nd, 2020 12:00:00 AM", 2020, 5, 2)]
        [InlineData ("Sunday May 3rd, 2020 12:00:00 AM", 2020, 5, 3)]
        [InlineData ("Monday May 4th, 2020 12:00:00 AM", 2020, 5, 4)]
        [InlineData ("Sunday May 10th, 2020 12:00:00 AM", 2020, 5, 10)]
        [InlineData ("Friday May 22nd, 2020 12:00:00 AM", 2020, 5, 22)]
        [InlineData ("Saturday May 23rd, 2020 12:00:00 AM", 2020, 5, 23)]
        [InlineData ("Sunday May 24th, 2020 12:00:00 AM", 2020, 5, 24)]
        [InlineData ("Friday February 28th, 2020 12:00:00 AM", 2020, 2, 28)]
        [InlineData ("Saturday February 29th, 2020 12:00:00 AM", 2020, 2, 29)]
        [InlineData ("Friday January 31st, 2020 12:00:00 AM", 2020, 1, 31)]
        public void CustomToStringWithoutTime_ReturnsCorrectString (string expected, int year, int month, int day) {

            DateTime input = new DateTime (year, month, day);

            string actual = input.CustomToString ();

            Assert.Equal (expected, actual);
        }

        [Theory]
        [InlineData ("Friday May 1st, 2020 12:01:02 AM", 2020, 5, 1, 0, 1, 2)]
        [InlineData ("Saturday May 2nd, 2020 03:04:05 AM", 2020, 5, 2, 3, 4, 5)]
        [InlineData ("Sunday May 3rd, 2020 02:33:45 PM", 2020, 5, 3, 14, 33, 45)]
        [InlineData ("Monday May 4th, 2020 04:22:11 PM", 2020, 5, 4, 16, 22, 11)]
        [InlineData ("Sunday May 10th, 2020 11:59:59 PM", 2020, 5, 10, 23, 59, 59)]
        [InlineData ("Friday May 22nd, 2020 09:33:55 PM", 2020, 5, 22, 21, 33, 55)]
        [InlineData ("Saturday May 23rd, 2020 03:54:23 PM", 2020, 5, 23, 15, 54, 23)]
        [InlineData ("Sunday May 24th, 2020 01:02:03 AM", 2020, 5, 24, 1, 2, 3)]
        [InlineData ("Friday February 28th, 2020 03:04:05 AM", 2020, 2, 28, 3, 4, 5)]
        [InlineData ("Saturday February 29th, 2020 10:06:07 PM", 2020, 2, 29, 22, 6, 7)]
        [InlineData ("Friday January 31st, 2020 11:44:44 AM", 2020, 1, 31, 11, 44, 44)]
        public void CustomToStringWithTime_ReturnsCorrectString (string expected, int year, int month, int day, int hour, int minute, int second) {
            DateTime input = new DateTime (year, month, day, hour, minute, second);

            string actual = input.CustomToString ();

            Assert.Equal (expected, actual);
        }
    }
}