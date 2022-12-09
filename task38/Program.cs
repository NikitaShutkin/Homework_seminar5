// Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(1,10000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "; ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max)
        {
            max = numbers[n];
        }
    if (numbers[n] < min)
        {
            min = numbers[n];
        }
}
Console.WriteLine($"Всего чисел: {numbers.Length}.");
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
