Console.WriteLine();
double[] arrayRealNumbers = new double[7];
for (int i = 0; i < arrayRealNumbers.Length; i++ )
{
    arrayRealNumbers[i] = new Random().Next(-50, 50);
    Console.Write(arrayRealNumbers[i] + " ");
}
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}
double point = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Разница максимальных ({maxNumber}) и минимальным ({minNumber}) элементов = {point}");
Console.WriteLine();