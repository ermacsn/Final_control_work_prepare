using System.Formats.Asn1;
using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;

string[] array = {"123345", "qweert", "dsfggdgd", "gfhghfh"}; //исходный массив
var random = new Random();


string strArray = "";
foreach (var item in array)
{
    strArray += item;
}
Console.WriteLine(strArray);

string[] resultArray = new string [strArray.Length]; // ограничивающее условие 

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

int b =0;
while (b < strArray.Length)
{
    b = b + random.Next(0,9);
    if (b > strArray.Length) break; 
    strArray = strArray.Insert(b, "\n");
}
Console.WriteLine(strArray); 