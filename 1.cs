using System;
class program
{
    public static void Main()
    {
        Console.WriteLine("tedad rooz sen khodet ro vared kon");
        string x = Console.ReadLine();
        int birthday = Convert.ToInt32(x);
        int year = (birthday / 365);
        birthday %= 365;
        int month = (birthday / 30);
        birthday %= 30;
        int week = (birthday / 7);
        birthday %= 7;
        int day=birthday;
        Console.WriteLine("sal=");
        Console.WriteLine(year);
        Console.WriteLine("mah=");
        Console.WriteLine(month);
        Console.WriteLine("hafte=");
        Console.WriteLine(week);
        Console.WriteLine("rooz=");
        Console.WriteLine(birthday);
        
    }ا
}