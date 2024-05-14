Console.Write("Input a string: ");
string str = Console.ReadLine();
Console.WriteLine(str.Length >= 5 && str.Substring(0, 5) != "wwwww");