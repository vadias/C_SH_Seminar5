// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
System.Console.Write("Сумма нечетных элементов массива ");

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
    int sum = 0;
    Console.Write("[");
     for(int i = 0; i < array.Length; i++) {
        if (i%2 != 0) {
           sum = sum + array[i];
        } 
         Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine(" ");
    Console.WriteLine(" = {0}", sum);
}

int[] temp_array = GenerateArray(4, 0, 100);
PrintTask(temp_array);