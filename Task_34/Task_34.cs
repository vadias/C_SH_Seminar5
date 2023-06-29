// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите длину массива");

int[] GenerateArray(int Lenght, int Min, int Max) {
    int[] array = new int[Lenght];
     Random random = new Random();
            for (int i = 0; i < Lenght; i++)
            {
                array[i] = random.Next(Min, Max);
            }

    return array;
}

void PrintTask(int[] array) {
    int count1 = 0;
    int count2 = 0;
    Console.WriteLine("В массиве: ");
    Console.Write("[");
    for(int i = 0; i < array.Length; i++) {
        if (array[i]%2 == 0) {
            count2++;
        } else {
            count1++;
        }
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
    Console.Write("Четных чисел: ");
    Console.Write(count2);
   // Console.Write("Не четных чисел: ");
   // Console.WriteLine(count1);
}

int nums = Convert.ToInt16(Console.ReadLine());
int[] temp = GenerateArray(nums, 0, 999);
PrintTask(temp);