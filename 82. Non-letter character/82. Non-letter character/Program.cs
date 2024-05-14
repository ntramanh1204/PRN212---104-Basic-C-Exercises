using System.Text.RegularExpressions;

string text = "Py@th12on";
Console.WriteLine(Regex.Replace(text, @"[^a-zA-Z]", ""));