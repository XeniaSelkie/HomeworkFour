// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int A = ReadInt("первое число");
int B = ReadInt("второе число");
if (A != 1 && A != 0)
Exponentiation(A, B);
else
Console.WriteLine($"Число {A}, возведённое в любую степень всегда равняется {A}");



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
    if (exponent == 0)
    Console.WriteLine($"Любое число, возведённое в степень {exponent} всегда равняется 1");
    else
    {
    int result = number;
    for (int count = 1; count < exponent; count++)
    result *= number;     
    Console.WriteLine($"Число {number}, возведённое в степень {exponent} равняется {result}");
    }
    
}