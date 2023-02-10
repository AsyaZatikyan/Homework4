/*
 Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// пишем метод чтобы, вывести массив на экран,

int[] InitArray()
 {
     int[] result = new int[8];
     Random rnd = new Random();

     for (int i = 0; i < result.Length; i++)
     {
         result[i] = rnd.Next(0,50);
     }

     return result;
 }

void PrintArry(int[] arr)
{
  int count = arr.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(arr[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int [] arr = InitArray();
PrintArry(arr);