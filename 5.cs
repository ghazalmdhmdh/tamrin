using System;
class program
{
    public static void Main()
    {
        double pool, darsadbank, sal, ayande;
        Console.WriteLine("sarmaye khod ra be riyal vared kon:");

        string num1 = Console.ReadLine();
        Console.WriteLine("darsad sood salane bank ra vared kon:");

        string num2 = Console.ReadLine();
        Console.WriteLine("tedad sal seporde khod ra vared kon:");

        string num3 = Console.ReadLine();


        pool = Convert.ToDouble(num1);
        darsadbank = Convert.ToDouble(num2);
        sal = Convert.ToDouble(num3);

        Console.WriteLine("sood shoma:");
        Console.WriteLine(sood(pool, darsadbank, sal));
        Console.WriteLine("sarmaye madnazar shoma:");
        string num4 = Console.ReadLine();
        ayande = Convert.ToDouble(num4);
        Console.WriteLine("modat zaman residan be sood madnazar:");

        soon(pool, ayande, darsadbank);



    }
    static double sood(double pool, double darsadbank, double sal)
    {
        for (int i = 0; i < sal; i++)
        {
            double darsadpool = pool * darsadbank;
            double poolnahaiyeksal = darsadpool + pool;
            pool = poolnahaiyeksal;
        }
        return pool;

    }
    static void soon(double pool, double ayande, double darsadbank)
    {
        for (int i = 1; ayande==pool; i++)
        {

            double darsadpool = pool * darsadbank;
            double poolnahaiyeksal = darsadpool + pool;
            pool = poolnahaiyeksal;
            

            if(ayande==pool){
                Console.WriteLine(i);
            }
                
            }


    }ا
}