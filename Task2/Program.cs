double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = ReadDouble("Введите b1: ");
double k1 = ReadDouble("Введите k1: ");
double b2 = ReadDouble("Введите b2: ");
double k2 = ReadDouble("Введите k2: ");

double x = (b2 * k1 - b1  * k1)/(k1 * (k1 - k2));
double y = (b2 * k1 - k2 * b1)/(k1 - k2);

Console.WriteLine($"({x},{y})");