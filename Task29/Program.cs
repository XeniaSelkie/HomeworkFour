// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int minElement = ReadInt("минимальное");
int maxElement = ReadInt("максимальное");
int[] randomArray = GetRandomArray(8, minElement, maxElement);
PrintArray(randomArray);

int ReadInt(string argument)
{
	Console.Write($"Укажите {argument} значение элемента массива: ");
	int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	}

	return number;
}

int [] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random number = new Random();

    for (int count = 0; count < length; count++)
    {
        array[count] = number.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}