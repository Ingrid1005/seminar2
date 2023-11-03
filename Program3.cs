int promph (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ChekWork (int check)
{
    if (check > 0 && check <= 7) 
        {
            return true;
        }
    Console.WriteLine("Это не день недели");
    return false;
}

bool weekend (int end)
{
    if (end>5)
        {
            return true;
        }
    return false;
}

int end = promph ("Введите день недели > ");
if (ChekWork(end))
{
    if (weekend(end))
    {
        Console.WriteLine("Это выходной");
    }
    else 
    {
        Console.WriteLine("Это рабочий день");
    }
}