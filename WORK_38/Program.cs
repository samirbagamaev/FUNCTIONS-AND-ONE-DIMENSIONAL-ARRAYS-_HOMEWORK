// Задайте массив натуральных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("ВВЕДИТЕ РАЗМЕР МАССИВА: ");
int [] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;  
}

 GetRandomArray( numbers);
int max = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());

int[] massive = GetRandomArray(5, 1, 155);
Console.WriteLine(string.Join(" , ", massive));

for(int i = 0; i < massive.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }

    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

