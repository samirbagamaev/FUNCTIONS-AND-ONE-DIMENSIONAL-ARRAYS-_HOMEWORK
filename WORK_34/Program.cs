// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*Console.WriteLine("ВВЕДИТЕ МАССИВ: ");
int [] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;  
}

int[] massive = GetRandomArray(10, 100, 999); //ДОПУСТИМ 10 ЭЛЕМЕНТОВ
Console.WriteLine(string.Join(",", massive));

int count = 0;
for(int i = 0; i < massive.Length; i++)
{
    massive[i] % 2 == 0;
    
}

Console.WriteLine($"У НАС ЕСТЬ {massive.Length} ЧИСЕЛ, КОЛИЧЕСТВО ЧЁТНЫХ ЧИСЕЛ В МАССИВЕ РАВНО {count}");
*/

//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||




Console.WriteLine("ВВЕДИТЕ МАССИВ: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
GetRandomArray(numbers);
PrintArray(numbers);
int count = 0;

for (int  i= 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"ВСЕГО У НАС ЕСТЬ {numbers.Length} ЧИСЕЛ, КОЛИЧЕСТВО ЧЕТНЫХ ЧИСЕЛ: {count}");

void GetRandomArray(int[] numbers)
{
    for(int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] +  " , ");
    }
    Console.Write("]");
    Console.WriteLine();
}

