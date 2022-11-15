bool CheckingTheSymbol(char symb)
{
    if (symb == '-' || symb == ',' || symb == '0' || symb == '1' || symb == '2' || symb == '3' || symb == '4' || symb == '5' || symb == '6' || symb == '7' || symb == '8' || symb == '9')
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите числа через запятую: ");
string stringOfNum = Console.ReadLine();
string numStr = String.Empty;
int count = 0;

for (int i = 0; i < stringOfNum.Length; i++)
{
    if (CheckingTheSymbol(stringOfNum[i]) == false)
    {
        Console.WriteLine("Вы ввели числа неправильно!");
        return;
    }

    if (stringOfNum[i] == ',' && numStr == String.Empty)
    {
        Console.WriteLine("Вы ввели числа неправильно!");
        return;
    }
    else if (stringOfNum[i] == ',' && numStr != String.Empty)
    {
        if (Convert.ToInt32(numStr) > 0)
        {
            count++;
        }

        numStr = String.Empty;
    }
    else
    {
        numStr = numStr + stringOfNum[i];
    }

}

if (numStr != String.Empty)
{
    if (Convert.ToInt32(numStr) > 0)
    {
        count++;
    }
}
else
{
    Console.WriteLine("Вы ввели числа неправильно!");
    return;
}

Console.WriteLine($"Число положительных чисел = {count}");