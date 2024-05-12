Console.Write("Enter the First number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the Second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter the Third number: ");
int third = int.Parse(Console.ReadLine());
Console.Write("Enter the Fourth number: ");
int fourth = int.Parse(Console.ReadLine());

Console.WriteLine($"The average of {first}, {second}, {third}, {fourth} is: {(first + second + third + fourth)/4}");