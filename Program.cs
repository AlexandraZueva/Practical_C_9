/*Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.*/


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int n = 0; // счетчик (количество цифр в data)
for (int i = 0; i < info.Length; i++) 
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[n + j] + " ");
    }
    n += info[i];
    Console.Write("; ");
}

n = 0;
for (int i = 0; i < info.Length; i++) // преобразуем получившиеся числа из двоичной в десятичную
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[n + j] * (int)Math.Pow(2, info[i] - 1 - j);
    }
    n += info[i];
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}