int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Это неподходящее число");
    return;
}
else
{
Console.WriteLine($"Введенное число {number}");
int second = number / 10 % 10;
Console.WriteLine($"Второе число > {second}");
}