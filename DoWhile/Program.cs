using System;
namespace DoWhile
{
    class Program{
        public static void Main(string[] args)
        {
          
                int number=int.Parse(Console.ReadLine());
                int digit=int.Parse(Console.ReadLine());
                Console.WriteLine(FindNthDigit(number,digit));
        }
         public static int FindNthDigit(int num ,int digit){
                int count==0;
                while(num!=0){
                    int remainder=num%10;
                    count++;
                    if(count==digit)
                        return remainder;
                    num/=10;
                }
                return 0;
            }
    }
}
