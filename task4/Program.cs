
int[] nums = new int[3];
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Введите число №{i + 1}:");
    var str = Console.ReadLine();
    int num = Convert.ToInt32(str);
    nums[i] = num;
}

int max = nums[0];
for (int i = 0; i < nums.Length; i++)
    if (nums[i] > max) max = nums[i];

Console.WriteLine($"Максимальное число: {max}");