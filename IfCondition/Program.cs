using System;
namespace IfCondition
{
    class Program{
        public static void Main(string[] args)
        {
           string input=Console.ReadLine();
                if(input=="January"||input=="February"||input=="December")
                    Console.WriteLine("Winter");
                else if(input=="March"||input=="April"||input=="May")
                    Console.WriteLine("Spring");
                else if(input=="September"||input=="October"||input=="November"||)
                    Console.WriteLine("Rainfall");
                else if(input=="August"||input=="JulY"||input=="June")
                    Console.WriteLine("Summer");
                else    
                    Console.WriteLine("Unknown");

        }
    }
}