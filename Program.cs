// Задаем начальный массив строк
string[] inputArray = {"12", "3345", "qwe", "rt", "dsfg", "gd", "d", ""," ", "gfh", "ghfh"}; //исходный массив

//функция удаляет строки у которых количество символав больше трех
//в качестве результата выводится количество строк,в которых символов меньше либо равно 3 
int ArraySort(string[] array) 
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 ) 
        {
             count += 1;
        }
        else
        {          
            array[i] = "\n";
        }
    }
    return count;   
}

//функция формирует выходной массив
string[] ArrayClear(int lengthArray, string[] array)
{
    string[] newArray = new string [lengthArray];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "\n")
        {
            newArray[index] = array[i];
            index += 1;
        }    
    }

    return newArray;
}

//функция выводит в консоль выходной массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        Console.WriteLine(array[i]);
    }
}

//Вывод результата
int count = ArraySort(inputArray);
string[] resultArray = ArrayClear(count, inputArray);
PrintArray(resultArray);
