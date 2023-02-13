// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Task27();

void Task27()
{
    int inputNumber = ReadInt("число");
    Console.WriteLine($"Сумма цифр в числе {inputNumber} равняется {SumDigits(inputNumber)}");
}

int ReadInt(string argument)
{
	Console.Write($"Введите {argument}: ");
    int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	}

	return number;
}

int SumDigits(int number)
{
    int result = 0;
    while(number > 0)
    {
    result += number % 10;
    number = number / 10;
    }
    return result;
}
