using System;
class program{
    public static void Main(){
        Console.WriteLine("please enter your number:");
        string num=Console.ReadLine();
        double number=Convert.ToDouble(num);
        double res=calc(number);
         Console.WriteLine("pow2:");
        Console.WriteLine(res);
         double res_2=calc2(number);
           Console.WriteLine("pow3:");
        Console.WriteLine(res_2);
    }
    private static double calc(double x){
        double a=Math.Pow(x,2);
        return a;
        double b=Math.Pow(x,3);
        return b;
    }
    
}