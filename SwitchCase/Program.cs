using System;
namespace IfCondition
{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter fist value:");
            double first=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            double second=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator:");
            char opt=Convert.ToChar(Console.ReadLine());
            switch(opt){
                case '+':{
                    Console.WriteLine(first+second);
                    break;
                }
                 case '-':{
                    Console.WriteLine(first-second);
                    break;
                }
                 case '*':{
                    Console.WriteLine(first*second);
                    break;
                }
                 case '/':{
                    Console.WriteLine(first/second);
                    break;
                }
                case '%':{
                    Console.WriteLine(first%second);
                    break;
                }
                default:{
                    Console.WriteLine("Operation invalid");
                    break;
                }
            }

        }
    }
}