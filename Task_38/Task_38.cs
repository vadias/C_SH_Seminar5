// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int maxarr = 100; //максимальное значение массива
double Min;
double Max;


double[] GenerateArray(int Lenght, double Min, double Max) {
    double[] array = new double[Lenght];
     Random random = new Random();
            for (int i = 0; i < Lenght; i++)
            {
                array[i] = Math.Round(random.NextDouble() * maxarr, 2);
            }

    return array;
}

void MinMax(double[] array, out double Min, out double Max) {
   Min = maxarr;
    Max = 0;
    for(int i = 0; i < array.Length; i++) {
        if(Min > array[i]) {
            Min = array[i];
        }
        if(Max < array[i]) {
            Max = array[i];
        }
    }
}

void PrintTask(double[] array, double min, double max) {
    double dif = 0;
    dif = max - min;
    Console.Write("[");
     for(int i = 0; i < array.Length; i++) {
     
         Console.Write($"{array[i]}, ");
    }
    Console.Write("] => ");
   
    Console.Write($"{max} - {min} = {dif}");

}

double[] temp_array = GenerateArray(10, 0.0, 100.00);
MinMax(temp_array, out Min, out Max);
PrintTask(temp_array, Min, Max);