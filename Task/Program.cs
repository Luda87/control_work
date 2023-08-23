/*
Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на 
старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


string [] ElementArray(string[] array, string[] newArray)
{
    int j = 0;
    int n =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
            n= j+1;
        }
    }
    Array.Resize(ref newArray, n);
return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
           { System.Console.Write($"{array[i],2}  ");}

    }

}

string[] array = new string[] { "один", "два", "три", "семь", "100" };
string[] newArray = new string[array.Length];
ElementArray(array,newArray);
PrintArray(newArray);