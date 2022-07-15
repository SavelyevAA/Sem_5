Console.Clear();
Console.Write($"количество элементов массива: ");
int numberElements = int.Parse(Console.ReadLine()!); 
Console.WriteLine();
int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("массив: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers =  RandomNumbers(numberElements, -10, 10);
Console.WriteLine();
Console.WriteLine($"\nСумма элементов: {randomNumbers}");
Console.WriteLine();