Console.Write("Ведите первое число - ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число - ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Ведите третье число - ");
int thirdNumber = int.Parse(Console.ReadLine());


if (firstNumber > secondNumber) {
    if (firstNumber > thirdNumber) Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber} -> max = {firstNumber}");
    else Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber} -> max = {thirdNumber}");
}
else {
    if (secondNumber > thirdNumber) Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber} -> max = {secondNumber}");
    else Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber} -> max = {thirdNumber}");
}
