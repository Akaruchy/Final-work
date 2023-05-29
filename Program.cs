// ИТОГОВАЯ РАБОТА
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

string[] arr1 = new string[5] { "12", "4765", "hello", "world", ";-)" };
string[] arr2 = new string[arr1.Length];
SecondArray(arr1, arr2);
PrintArray(arr2);

void SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}