using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace MethodTypes{
    class Program{
        public static void Main(string[] args)
        {
            bool status=true;
            while(status){
                Console.WriteLine("Enter the First Number:");
                int first=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second Number:");
                int second=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operator: \n1.Addition\n2.Subtraction\n3.Multiplication\n4.Divion\n");
                int val=int.Parse(Console.ReadLine());
                switch(val){
                    case 1:{
                        addition(first,second);
                        break;
                    }
                    case 2:{
                        subtraction(first,second);
                        break;
                    }
                    case 3:{
                        multiplication(first,second);
                        break;
                    }
                    case 4:{
                        division(first,second);
                        break;
                    }
                }
                Console.WriteLine("Do you want to try again for different parameters  (yes/no)");
                string check=Console.ReadLine();
                if(check=="yes"){
                    
                }
                else if(check=="no")
                    status=false;
            }
            static void addition(int a,int b){
                Console.WriteLine(a+b);
            }
            static void subtraction(int a,int b){
                Console.WriteLine(a-b);
            }
            static void multiplication(int a,int b){
                Console.WriteLine(a*b);
            }
            static void division(int a,int b){
                Console.WriteLine(a/b);
            }
        }
    }
}