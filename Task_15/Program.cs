Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 5)
    Console.WriteLine("Идем на работку!");
else
    Console.WriteLine("Выходной!!!");