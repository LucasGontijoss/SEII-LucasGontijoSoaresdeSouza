using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// DaysOfWeek.cs

internal class DaysOfWeek
{
    public static void PrintDays()
    {
        string[] myArray = new string[7];
        myArray[0] = "Monday";
        myArray[1] = "Tuesday";
        myArray[2] = "Wednesday";
        myArray[3] = "Thursday";
        myArray[4] = "Friday";
        myArray[5] = "Saturday";
        myArray[6] = "Sunday";

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        List<string> list = new List<string>();
        list.Add("Monday");
        list.Add("Tuesday");
        list.Add("Wednesday");
        list.Add("Thursday");
        list.Add("Friday");
        list.Add("Saturday");
        list.Add("Sunday");

        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Substring(0, 3);
            Console.WriteLine(list[i]);
        }
        
    }
}
