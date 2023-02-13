// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Task25();

void Task25()
{
    int A = ReadInt("первое число");
    int B = ReadInt("второе число");
    
    Exponentiation(A, B);
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

void Exponentiation(int number, int exponent)
{
    int result = number;
    for (int count = 1; count < exponent; count++)
    result = result * number;     
    Console.WriteLine($"Число {number}, возведённое в степень {exponent} равняется {result}");
}