//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomarray(numbers);
PrintArray(numbers);



int sum = 0;
for (int j = 0; j < numbers.Length; j+=2) //int j = 1; - Будут чётные.
    sum = sum + numbers[j];
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");


void FillArrayRandomarray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.WriteLine("]");
}