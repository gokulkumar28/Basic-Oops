using System;
namespace ForLoop
{
    class Program{
        public static void Main(string[] args)
        {
            // Console.Write("Enter start number:");
            // double start=Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter end number:");
            // double end=Convert.ToDouble(Console.ReadLine());
            // double sum=0;
            // for(double i=start+1;i<end;i++){
            //     double square=i*i;
            //      sum+=square;
            // }
            // Console.WriteLine(sum);

            // int n=int.Parse(Console.ReadLine());
            //    string str=Console.ReadLine();
            //    string[] arr=str.Split(" ");
            //    for(int i=0;i<arr.Length;i++){
            //     if(i!=arr.Length-1 && int.Parse(arr[i])>=int.Parse(arr[i+1]))
            //         Console.Write(arr[i]+" ");
            //     else{
            //         if(i!=arr.Length-1)
            //         Console.Write(arr[i+1]+ " ");
            //    }
            //    }

                string str=Console.ReadLine();
                string ans="";
                for(int i=0;i<str.Length;i++){
                    int count=0;
                    for(int j=0;j<str.Length;j++){
                        if(str[i]==str[j])
                            count++;
                    }
                    ans=ans+str[i]+count.ToString();
                }
                Console.Write(ans);



        }
    }
}
