Console.Write("Enter the amount of celsius: ");
double cel = double.Parse(Console.ReadLine());
double kel = cel + 273.15;
double fah = cel * 9 / 5 + 32;
Console.WriteLine(kel);
Console.WriteLine(fah);