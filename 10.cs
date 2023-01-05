using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("please enter number1 for b m m and kmm :");
        string num1 = Console.ReadLine();
        Console.WriteLine("please enter number2 for b m m and kmm:");

        string num2 = Console.ReadLine();
        int a = Convert.ToInt32(num1);
        int b = Convert.ToInt32(num2);
        int n = a;
        int m = b;
        int res = bmm(a, b);
        Console.WriteLine("bmm:");
        Console.WriteLine(res);
        int res2 = kmm(n, m);
        Console.WriteLine("kmm:");
        Console.WriteLine(res2);


    }

    static int bmm(int a, int b)
    {


        while (true)
        {
            if (b == 0) break;
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
    static int kmm(int a, int b)
    {
        int n = a;
        int m = b;
        while (true)
        {
            if (b == 0) break;
            int temp = a % b;
            a = b;
            b = temp;
        }
        return n * m / a;
    }
    
}