using System.Security.Cryptography.X509Certificates;

class Program
{
    static bool checkPalindrome(string str)
    {
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        return new string(c).Equals(str);
    }
    static void Main()
    {
        string str1 = "aaa";
        string str2 = "abcd";
        Console.WriteLine(checkPalindrome(str1));
        Console.WriteLine(checkPalindrome(str2));
    }
}