class Program { 

    static void Main(String[] args)
    {
        int n = 321;
        Console.WriteLine("Next: " + nextPrime(n));
    }
    static int nextPrime(int n)
    {
        int num = n;
        while (true)
        {
            if (!checkPrime(num))
            {
                num++;
            } else
            {
                return num;
            }
        }
    }

    static bool checkPrime(int n) { 
        if (n < 2) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++ )
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
