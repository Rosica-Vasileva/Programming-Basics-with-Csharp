﻿

string dayOfWeek = Console.ReadLine();

switch(dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        Console.WriteLine("Working day");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend day");
        break;
    default:
        Console.WriteLine("Error");
        break;

}
