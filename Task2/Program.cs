Console.Write("Ведите первое число - ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число - ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber > secondNumber) Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {firstNumber}");
else Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {secondNumber}");
