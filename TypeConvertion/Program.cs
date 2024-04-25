
using System;
namespace TypeConvertion
{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name=Console.ReadLine();
            Console.Write("Enter age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter mark of subject1:");
            double mark1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject2:");
            double mark2=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject3:");
            double mark3=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Grade:");
            char grade=Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Mobile number:");
            long mobile=Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Main id:");

            string mail=Console.ReadLine();
            double total=mark1+mark2+mark3;
            double avg=total/3;
            Console.WriteLine($"Trainee Details are:\nName: {name} \nAge: {age}\nMobile: {mobile}\nMark1: {mark1}\nMark2: {mark2}\nMark3: {mark3}\nTotal: {total}\nAverage: {avg}\nGrade: {grade}\nMail id: {mail}\n ");
        }
    }
    
}

