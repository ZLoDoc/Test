void PrintArray(string[] array)
{
    for (int i = 0; i <= array.Length - 1; i++) Console.WriteLine(array[i]);
}
string[] ResultArray(string[] array)
{
    string[] temporaryArray = new string[array.Length];
    int temporaryArrayIndex = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3)
        {
            temporaryArray[temporaryArrayIndex] = array[i];
            temporaryArrayIndex++;
        }
    }
    string[] resultArray = new string[temporaryArrayIndex];
    for (int resultArrayindex = 0; resultArrayindex <= temporaryArrayIndex - 1; resultArrayindex++)
    {
        resultArray[resultArrayindex] = temporaryArray[resultArrayindex];
    }
    return (resultArray);
}
Console.Write("Задайте длину матрицы :");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
for (int i = 0; i <= num - 1; i++)
{
    Console.Write($"Введите {i + 1} набор символов :");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Из заданной матрицы символов :");
PrintArray(array);
string[] result = ResultArray(array);
if (result.Length != 0) Console.WriteLine("Сформирована матрица из элементов длинной 3 и менее символов :");
else Console.WriteLine("В заданной матрице элементы из 3-х и менее символов отсутствуют");
PrintArray(result);