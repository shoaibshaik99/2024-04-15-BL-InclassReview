using System.Text.RegularExpressions;

namespace DateRegEx
{
    internal class DateRegex
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d{4}[-/\.]\d{2}[-/\.]\d{2}";

            Console.WriteLine("Enter the date to check if it is in correct format(year,month,day)");
            string usrInputDate = Console.ReadLine();
            bool dateIsMatch = Regex.IsMatch(usrInputDate, pattern);
            if (dateIsMatch)
            {
                Console.WriteLine("Date is in correct format");
            }
            else
            {
                Console.WriteLine("Date is in Incorrect format");
            }
        }
    }
}