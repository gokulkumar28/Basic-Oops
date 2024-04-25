using System;
namespace DateTimeAssignmnet{
    class Program{
        public static void Main(string[] args)
        {
            DateTime dob=new DateTime(2021,8,10,10,40,32);
            Console.WriteLine(dob.Day);
            Console.WriteLine(dob.Month);
            Console.WriteLine(dob.Year);
            bool check=DateTime.TryParseExact(Console.ReadLine(),"dd MM yyyy hh mm ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime date);
            Console.Write(date.ToString("dd MM yyyy tt"));
            Console.WriteLine(dob.Day);
            string data=date.ToString("dd MM yyyy tt");

        }
    }
}