using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");

            // Save the input to a variable.

            string inputmonthNum = Console.ReadLine();

            // Use the if statment to update the monthName variable based on the user's input.
            string monthName = string.Empty;
            
            
            if (inputmonthNum == "1")
                {
                monthName = "January";
            }

            else if (inputmonthNum == "2")
            {
                monthName = "February";
            }

            else if (inputmonthNum == "3")
            {
                monthName = "March";
            }

            else if (inputmonthNum == "4")
            {
                monthName = "April";
            }

            else if (inputmonthNum == "5")
            {
                monthName = "May";
            }

            else if (inputmonthNum == "6")
            {
                monthName = "June";
            }

            else if (inputmonthNum == "7")
            {
                monthName = "July";
            }

            else if (inputmonthNum == "8")
            {
                monthName = "August";
            }

            else if (inputmonthNum == "9")
            {
                monthName = "September";
            }

            else if (inputmonthNum == "10")
            {
                monthName = "October";
            }

            else if (inputmonthNum == "11")
            {
                monthName = "November";
            }

            else if (inputmonthNum == "12")
            {
                monthName = "December";
            }

            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
