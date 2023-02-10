/* 
Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string massege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massege);
        if(int.TryParse(Console.ReadLine(), out result ))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число, попробуйте еще раз: ");
        }
        
    }
    return result;
}

int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int position = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      position = number - number % 10;
      result = result + (number - position);
      number = number / 10;
    }
   return result;
  }
int number = GetNumber("Вводите число: ");
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
