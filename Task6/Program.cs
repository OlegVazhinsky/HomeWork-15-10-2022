Console.Write("Ведите число - ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber % 2 == 0) Console.WriteLine($"Число {userNumber} четное");
else Console.WriteLine($"Число {userNumber} не четное");