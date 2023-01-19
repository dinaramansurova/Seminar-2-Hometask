Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
m = n / 10 % 10;
Console.WriteLine($"{m}");