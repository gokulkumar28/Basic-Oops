using System;
namespace StringManipulation{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the big String");
            string bigString=Console.ReadLine();
            Console.WriteLine("Enter the small String");
            string smallString=Console.ReadLine();
            string str=bigString.Replace(smallString,"$");
            int count=0;
            for(int i=0;i<str.Length;i++){
                Console.WriteLine(str[i]);
                if(str[i]=='$'){
                    count++;
                }
            }
            Console.WriteLine("String searched count is"+count);

        }
    }
}