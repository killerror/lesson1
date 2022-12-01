Console.Write("Введите число: ");
var str = Console.ReadLine();
int num = Convert.ToInt32(str);

Console.Write($"Введенное число {(((num % 2) == 0) ? "четное" : "нечетное")}");
