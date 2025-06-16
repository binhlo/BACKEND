using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so: ");
        int n = int.Parse(Console.ReadLine());

        bool laNT = true;

        if (n < 2)
        {
            laNT = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laNT = false;
                    break;
                }
            }
        }

        if (laNT)
            Console.WriteLine(n + " la so nguyen to");
        else
            Console.WriteLine(n + " khong phai so nguyen to");
    }
}
