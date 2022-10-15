Console.Write("Ведите число - ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber >= 0) {
    for (int i = 2; i <= userNumber; i = i + 2) {
        Console.Write($"{i} ");
    }
}
else {
    for (int i = userNumber; i < 0; i = i + 2) {
        Console.Write($"{i} ");
    }
}
