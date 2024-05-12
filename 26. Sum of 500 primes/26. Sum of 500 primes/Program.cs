using System;

class Program
{
    public static void Main(String[] args)
    {
        int sum = 0, count = 0;
        for (int i = 2; count < 500; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
                count++;
            }
        }
        Console.WriteLine(sum);
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); ++i)
        {
            if (n % i == 0) return false; // If 'n' is divisible by 'i', it's not a prime number
        }

        return true;
    }

}