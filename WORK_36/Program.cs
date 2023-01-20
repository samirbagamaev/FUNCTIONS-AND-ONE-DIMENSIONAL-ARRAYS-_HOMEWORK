// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("ВВЕДИТЕ МАССИВ: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
GetRandomArrays(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
{
    sum = sum + numbers[i];
}
    Console.WriteLine($"ВСЕГО {numbers.Length} ЧИСЕЛ, СУММА ЭЛЕМЕНТОВ НА НЕЧЁТНЫХ ПОЗИЦИЯХ РАВНА {sum}");

 void GetRandomArrays(int[] numbers)
{
    for(int a = 0; a < numbers.Length; a++)
        {
            numbers[a] = new Random().Next(0,100);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " , ");
        }
    Console.Write("]");
    Console.WriteLine();
}