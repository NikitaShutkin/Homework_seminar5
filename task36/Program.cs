// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}


void PrintArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}


Console.Clear();
int ReadInt(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int size = ReadInt("Введите размер массива: ");

int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечётных позиций = {result}");