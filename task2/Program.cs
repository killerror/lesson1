Console.Write("Введите первое число: ");
var str = Console.ReadLine();
int num0 = Convert.ToInt32(str);

Console.Write("Введите второе число: ");
str = Console.ReadLine();
int num1 = Convert.ToInt32(str);

if (num0 >  num1) Console.WriteLine("Первое число больше");
if (num1 >  num0) Console.WriteLine("Второе число больше");
if (num0 == num1) Console.WriteLine("Числа равны");
