using System.Xml.Serialization;



string[] array = {"123345", "qweert", "dsfggdgd", "gfhghfh"}; //исходный массив
int numberOfSymbol = 2; //количество символов в новых массивах

int sizeNewArray = 0;
foreach (var item in array)
{
    sizeNewArray+=item.Length;
}
sizeNewArray  = math.
Console.WriteLine(sizeNewArray);
string[] newArray = new string[sizeNewArray];

int k = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        newArray[k]=newArray[k] + array[i][j];
    }
}


