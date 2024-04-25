using System;
namespace IfCondition
{
    class Program{
        public static void Main(string[] args)
        {
        int count=0;
        for(int i=0;i<50;i++){
            if(i%2==0){
                Console.Write(i +" ");
                count++;
            }
            if(count==25)
                break;
        }
        Console.WriteLine("\nenter a number");
        bool input=false;
        int outer=28;
        while(input!=true){
           bool val=int.TryParse(Console.ReadLine(),out outer);
           if(val==true){
                input=true;
           }
           else{
            Console.WriteLine("Invalid Input format.Please enter the input in number format");
           }
        }
        }
    }
}