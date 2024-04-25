using System;
namespace ArrayClassroomAssignment
{
    class Program{
        public static void Main(string[] args)
        {
           int size=int.Parse(Console.ReadLine());
           string[] arr=new string[size];
           for(int i=0;i<size;i++){
                arr[i]=Console.ReadLine();
           }
           Console.WriteLine("Enter the name to search:");
           string search=Console.ReadLine();
           bool signal=true;
           for( int i=0;i<size;++i ){       
                if(arr[i].Equals(search)){
                    signal=false;
                    Console.WriteLine($"The {arr[i]} is present in array and index is: "+i);
                }   
           }
           if(signal==true){
                Console.WriteLine("The name is not present in array");
           }
           foreach(string j in arr){
                if(j.Equals(search)){
                    Console.WriteLine("The name is present in array");
                }
           } s
        }
    }
}