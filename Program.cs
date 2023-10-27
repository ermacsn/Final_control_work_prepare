using System.Formats.Asn1;
using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;

// Задаем начальные параметры
string[] array = {"123345", "qweert", "dsfggdgd", "gfhghfh"}; //исходный массив
int randomMax = 4;
int randomMin = 0;

var random = new Random();

//Собираем из элементов исходного массива строку
string strArray = "";
foreach (var item in array)
{
    strArray += item;
}
Console.WriteLine(strArray); // Выводим строку для сравнения 
Console.WriteLine($"Количество элементов от {randomMin} до {randomMax}.");

//Разделяем строку символом "\n" на части. Количество элементов в каждой части от randomMin до randomMax
int count_b = 0;
int count_a = 0; // количество символов перевод каретки
while (count_b < strArray.Length)
{
    count_b = count_b + random.Next(randomMin, randomMax);
    if (count_b > strArray.Length) break; 
    strArray = strArray.Insert(count_b, "\n");
    count_b = count_b + 1;
    count_a = count_a + 1;
}

//Console.WriteLine($"Количество переводов каретки: {count_a}");
//Console.WriteLine($"Элементы отсортированного массива: ");
//Console.WriteLine(strArray);


//Формируем выходной массив
string[] resultArray = new string [count_a + 1]; 
int count_j = 0; // индекс элементов выходного массива
for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i] == '\n') count_j = count_j + 1;
    else 
    {
        resultArray[count_j] = resultArray[count_j] + strArray[i];
    } 
}

//Выводим массив
Console.WriteLine("Выходной массив: ");
for (int i = 0; i < resultArray.Length; i++)
{
      Console.WriteLine(resultArray[i]);    
}


/*
Это еще один вариант решения
string[] resultArray = new string [strArray.Length]; // ограничивающее условие: количество элементов в выходном массиве не больше, чем во входном символов 

int n = 0;
for (int i = 0; i < resultArray.Length; i++)
{
    if (n < strArray.Length - 1)
    {
        int k = random.Next(0,2);
        if (strArray.Length - n < k) k = strArray.Length - n;
        for (int j = 0; j < k; j++)
        {
            resultArray[i] = resultArray[i] + strArray[n];
            n = n + 1;
        }
    }
    else resultArray[i] = "\n";    
}
   
for (int a = 0; a < resultArray.Length; a++)
{
    if (resultArray[a] == "\n") break;
    Console.WriteLine(resultArray[a]);    
}
*/

