using System;
using System.ComponentModel;
namespace DateTimeAssignment{
    class Program{
        public static void Main(string[] args)
        {
            // DateTime dob=new DateTime(2013,4,23,12,1,32);
            // Console.WriteLine(dob.Year);
            // Console.WriteLine(dob.Month);
            // Console.WriteLine(dob.Day);
            // Console.WriteLine(dob.Hour);
            // Console.WriteLine(dob.Minute);
            // Console.WriteLine(dob.Second);
            // Console.WriteLine(dob.ToString("dd/MM/yyyy hh:mm:ss tt"));
            // string date=dob.ToString("dd/MM/yyyy hh:mm:ss tt");
            // Console.WriteLine($"{dob.ToString("tt ss:mm:hh yyyy/MM/dd")} ");
            // bool flag = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime check);
            // Console.WriteLine(check.ToString("dd/MM/yyyy"));
            //  Console.WriteLine(check.ToString("dd"));
            //   Console.WriteLine(check.ToString("MM"));
            //    Console.WriteLine(check.ToString("yyyy"));
            // Console.WriteLine(flag); 


            //     bool flag=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss.fff",null,System.Globalization.DateTimeStyles.None,out DateTime date);
            //     Console.WriteLine("year = "+date.ToString("yyyy"));
            //     Console.WriteLine("month = "+date.ToString("MM"));
            //     Console.WriteLine("hour = "+date.ToString("dd"));
            //     Console.WriteLine("minute = "+date.ToString("mm"));
            //     Console.WriteLine("second = "+date.ToString("ss"));
            //   Console.WriteLine("millisecond = "+date.ToString("fff"));

            // bool flag=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss.fff",null,System.Globalization.DateTimeStyles.None,out DateTime date);
            //     Console.WriteLine("year = "+date.ToString("yyyy"));
            //     Console.WriteLine("month = "+date.ToString("MM"));
            //     Console.WriteLine("hour = "+date.ToString("dd"));
            //     Console.WriteLine("minute = "+date.ToString("mm"));
            //     Console.WriteLine("second = "+date.ToString("ss"));
            //     Console.WriteLine("millisecond = "+date.ToString("fff"));

            // double salary=double.Parse(Console.ReadLine());
            //     double hra=(double)10/100*salary;
            //     Console.WriteLine(hra);
            //     double da=(double)10/100*salary;
            //     Console.WriteLine(da);
            //     double monthlySalary=salary+hra+da;
            //     Console.WriteLine(monthlySalary);
            //     double annualSalary=12*monthlySalary;
            //     double tax=(double)5/100*annualSalary;
            //     double ans=annualSalary-tax;
            //     Console.WriteLine(ans);

            // double basicSalary=double.Parse(Console.ReadLine());
            //     double hra;
            //     double da;
            //     double monthlySalary;
            //     double annualSalary=0;
            //     if(basicSalary<=10000){
            //          hra= (double)20/100*basicSalary;
            //          da=(double)80/100*basicSalary;
            //          monthlySalary=basicSalary+hra+da;
            //          annualSalary=12*monthlySalary;
            //     }
            //     else if(basicSalary<=20000&& basicSalary>10000){
            //         hra=(double)25/100*basicSalary;
            //         da=(double)90/100*basicSalary;
            //         monthlySalary=basicSalary+hra+da;
            //         annualSalary=12*monthlySalary;
            //     }
            //     else if(basicSalary>20000){
            //         hra=(double)30/100*basicSalary;
            //         da=(double)95/100*basicSalary;
            //         monthlySalary=basicSalary+hra+da;
            //         annualSalary=12*monthlySalary;
            //     }
            //     double tax=(double)7/100*annualSalary;
            //     double takeHomeSalary=annualSalary-tax;
            //     Console.WriteLine("Annual Gross Salary: "+annualSalary);
            //     Console.WriteLine("Annual Take-Home Salary: "+takeHomeSalary);


            // long number=long.Parse(Console.ReadLine());
            //     int i=1;
            //     while(number!=0){
            //         string length=i.ToString();
            //         if(i<10)
            //             Console.WriteLine(i);
            //         else if(length.Length==3){
            //             int val=i;
            //             int sum=0;
            //             while(val!=0){
            //                 int remainder=val%10;
            //                 int cube=remainder*remainder*remainder;
            //                 sum=sum+cube;
            //                 val/=10;
            //             }
            //             if(i==sum){
            //                 Console.WriteLine(i);
            //                 }
            //         }
            //          else if(length.Length==4){
            //             int val=i;
            //             int sum=0;
            //             while(val!=0){
            //                 int remainder=val%10;
            //                 int cube=remainder*remainder*remainder*remainder;
            //                 sum=sum+cube;
            //                 val/=10;
            //             }
            //             if(i==sum)
            //                 Console.WriteLine(i);
            //         }
            //         i++;
            //         number--;
            //     }


            //  int start=int.Parse(Console.ReadLine());
            //     int difference=int.Parse(Console.ReadLine());
            //     int endValue=int.Parse(Console.ReadLine());
            //     int sum=0;
            //     int val=start;
            //     for(int i=0;i<10;i++){
            //         sum=sum+val;
            //         val=val+difference;
            //     }
            //     Console.WriteLine(sum);

            //   double salary=double.Parse(Console.ReadLine());
            //    int month=int.Parse(Console.ReadLine());
            //    int year=int.Parse(Console.ReadLine());
            //    int leave=int.Parse(Console.ReadLine());
            //    DateTime date=DateTime.Parse($"{month}\n{year}");
            //     int totalDays=DateTime.DaysInMonth(year,month);
            //     int workingDay=totalDays-leave;
            //     double leaveSalary=(double)leave/totalDays*salary;
            //     double takHomesalary=salary-leaveSalary;
            //     Console.WriteLine("Take-Home Salary: "+Math.Round(takHomesalary,2));
                
              
            //  bool check=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime date);
            //     int size=int.Parse(Console.ReadLine());
            //     int count=0;
            //     for(int i=0;i<size;i++){
            //         check=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
            //         string day=date.DayOfWeek.ToString();
            //         if(day.ToString()=="Saturday"||date.ToString()=="Sunday"){
            //             count++;
            //             Console.WriteLine("Holiday:-)");
            //         }
            //     }
            //     if(count>0)
            //             Console.WriteLine("Holiday:-)");
                        
            //     else
            //             Console.WriteLine("Not an Holiday:-(");

            //  double value=double.Parse(Console.ReadLine());
            //    double times=double.Parse(Console.ReadLine());
            //    double calculate=1+value;
            //    for(int i=2;i<times;i++){
            //     double factorial=1;
            //     double pow=1;
            //         for(int j=1;j<=i;j++){
            //             pow=pow*value;
            //             factorial*=j;
            //         }
            //         double series=pow/factorial;
            //         calculate+=series;
            //    }
            //    Console.WriteLine(calculate);


            // int one=2;
            // int two=3;
            // int[,] arr1=new int[one,two];
            // int[,] arr2=new int[two,one];
            // for(int i=0;i<one;i++){
            //     for(int j=0;j<two;j++){
            //         arr1[i,j]=int.Parse(Console.ReadLine());
            //     }
            // }
            // for(int i=0;i<two;i++){
            //     for(int j=0;j<one;j++){
            //         arr2[i,j]=int.Parse(Console.ReadLine());
            //     }
            // }
            // for(int i=0;i<one;i++){
            //     int multi=1;
            //     int sum=0;
            //     for(int k=0;k<one;k++){
            //     for(int j=0;j<two;j++){
            //         multi=arr1[k,j]*arr2[k,j];
            //         sum+=multi;
            //     }
            //     Console.Write(sum+ " ");
            //     }
            //     Console.WriteLine();
            // }
            

            // string str=Console.ReadLine();
            // string empty="";
            // for(int i=0;i<str.Length;i++){
            //     int count=0;
            //     for(int j=i+1;j<str.Length;j++){
            //         if(str[i]==str[j]){
            //             str.Replace(str[j],' ');
            //             count++;
            //             Console.WriteLine(str);
            //         }
            //     }
            //     if(count==0)
            //     empty=empty+str[i];
            // }
            // Console.WriteLine(empty);


           

            // string str=Console.ReadLine();
            // string empty="";
            // for(int i=0;i<str.Length;i++){
            //     int count=0;
            //     for(int j=i+1;j<str.Length;j++){
            //         if(str[i]==str[j]){
            //             str.Replace(str[j],' ');
            //             count++;
            //             Console.WriteLine(str);
            //         }
            //     }
            //     if(count==0)
            //     empty=empty+str[i];
            // }
            // Console.WriteLine(empty);

            //    string str=Console.ReadLine();
            // string[] stringarr=str.Split(" ");
            // char[] arr1=stringarr[0].ToCharArray();
            // char[] arr2=stringarr[1].ToCharArray();
            // Array.Sort(arr1);
            // Array.Sort(arr2);
            // int count=0;
            // if(stringarr[0].Length==stringarr[1].Length){
            //     for(int i=0;i<stringarr[0].Length;i++){
            //         if(arr1[i]==arr2[i]){
            //             count++;
            //         }
            //     }
            //     if(count==arr1.Length)
            //         Console.WriteLine("Anagrams");
            //     else
            //         Console.WriteLine("Not Anagrams");
            // }
            // else
            //     Console.WriteLine("Not Anagrams");  

            int val=12;
            int  val2=37;
            Console.WriteLine(val>val2);
        }
    }
}