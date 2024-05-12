string str = "w3resource";
Console.WriteLine($"Original: {str}");
str = str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
Console.WriteLine( str );