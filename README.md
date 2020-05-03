# CustomDateTimeExtension
My custom DateTime ToString() extension method.  Creates strings with "1st", "2nd", "3rd", "4th" for day.


```cs
DateTime input = new DateTime (new DateTime(2019, 12, 31, 23, 59, 59));
string actual = input.CustomToString ();

// Actual is: Tuesday December 31st, 2020 11:59:59 PM
```
