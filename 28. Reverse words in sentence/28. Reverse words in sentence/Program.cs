string str = "Display the pattern like pyramid using the alphabet.";
string[] words = str.Split(' ');
string reversed = string.Join(" ", words.Reverse());
Console.WriteLine($"Original String: {str}");
Console.WriteLine($"Reverse String: {reversed}");
