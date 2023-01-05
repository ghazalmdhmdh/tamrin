using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("^mohasebe rishe haye moadele daraje dovom^");
        Console.WriteLine("please enter a:");
        string num1 = Console.ReadLine();
        Console.WriteLine("please enter b:");
        string num2 = Console.ReadLine();
        Console.WriteLine("please enter c:");
        string num3 = Console.ReadLine();
        double a = Convert.ToDouble(num1);
        double b = Convert.ToDouble(num2);
        double c = Convert.ToDouble(num3);
        delta(a, b, c);


    }
    static void delta(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("a not valid");

        }
        double x = b * b - 4 * a * c;
        Console.WriteLine("delta=");
        Console.WriteLine(x);
        if (x > 0)
        {
            double y = -b - (Math.Sqrt(b * b - 4 * a * c) / 2 * a);
            double y2 = -b + (Math.Sqrt(b * b - 4 * a * c) / 2 * a);
            Console.WriteLine("rishe aval:");
            Console.WriteLine(y);
            Console.WriteLine("rishe dovom:");
            Console.WriteLine(y2);
        }
        if (x < 0)
        {
            Console.WriteLine("rishe haghighi nadarad");
        }
        if (x == 0)
        {
            double y = -b / (2 * a);
            Console.WriteLine("yek rishe darad");
            Console.WriteLine(y);
        }


        
    }ا
}