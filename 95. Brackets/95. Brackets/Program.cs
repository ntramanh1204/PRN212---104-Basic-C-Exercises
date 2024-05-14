class Program
{
    static void Main(string[] args)
    {
        string text = "<>";
        Console.WriteLine(brackets(text));
    }

    public static bool brackets(string s)
    {
        Stack<char> ch = new Stack<char>();

        foreach (var item in s.ToCharArray())
        {
            if (item == '(')
                ch.Push(')');
            else if (item == '<')
                ch.Push('>');
            else if (item == '[')
                ch.Push(']');
            else if (item == '{')
                ch.Push('}');
            else if (ch.Count == 0 || ch.Pop() != item)
                return false;
        }

        return ch.Count == 0;
    }

}