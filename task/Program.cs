Console.Write("Введите количество строк в массиве: ");
int quantityString = int.Parse(Console.ReadLine());
int lengthString = 3;


string[] GetArrayStart(int N)
{
   string[] array1 = new string[N];
   for (int i = 0; i < array1.Length; i++)
   {
      Console.WriteLine($"Введите {i + 1}-й элемент: ");
      string element = Convert.ToString(Console.ReadLine());
      array1[i] = element;
   }
   return array1;
}

string[] GetArrayFinal(string[] array, int N)
{
   int count1 = 0;
   for (int j = 0; j < array.Length; j++)
   {
      if (array[j].Length <= lengthString)
      {
         count1++;
      }
   }
   string[] array2 = new string[count1];
   int count2 = 0;
   for (int j = 0; j < array.Length; j++)
   {
      if (array[j].Length <= lengthString)
      {
         array2[count2] = array[j];
         count2++;
      }
   }
   return array2;
}

void PrintArray(string[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
      if (i == array.Length - 1)
      {
         Console.Write($"'{array[i]}'");
      }
      else
      {
         Console.Write($"'{array[i]}', ");
      }
   }
   Console.Write("]");
}

string[] arrayStart = GetArrayStart(quantityString);
Console.WriteLine();
PrintArray(arrayStart);
Console.Write(" -> ");
string[] arrayFinal = GetArrayFinal(arrayStart, quantityString);
PrintArray(arrayFinal);