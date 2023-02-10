/*
 Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Getnumber(string massege)
{
  int result = 0;
  while (true)
  {
    Console.WriteLine(massege);
    if(int.TryParse(Console.ReadLine(), out result))
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

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }

    return result;
}

  int numberA =(Getnumber("Введите число A: "));
  int numberB =(Getnumber("Введите число B: "));


  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);


