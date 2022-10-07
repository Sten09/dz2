/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введи цифру дня недели: ");
int Numberday = Convert.ToInt32(Console.ReadLine());

void Week (int Numberday) 
{
  if (Numberday == 6 || Numberday == 7) 
    Console.WriteLine("этот день выходной");
    else if (Numberday < 1 || Numberday > 7) 
      Console.WriteLine("это не день недели");
    else Console.WriteLine("этот день не выходной");
}
Week(Numberday);