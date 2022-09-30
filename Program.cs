Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(name);
Console.Write($"Квадрат {number} = {number*number}");
