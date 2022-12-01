Console.Write("Введите целевое число: ");
var str = Console.ReadLine();
int num = Convert.ToInt32(str);

for (int i = 1; i <= num; i++)
    if ((i % 2) == 0)
        Console.Write(i + " ");
