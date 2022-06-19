// ---Task 13
//Console.WriteLine("Введите число ");
//int number = Convert.ToInt32(Console.ReadLine());
//number = Math.Abs(number);
//if(number<100)
//{
//Console.WriteLine("Третьей цифры нет");
//}
//else{
  //  while(number>999)
  //  {
  //      number = number/10;
  ///  }
//Console.WriteLine(number%10);
//}
// - - - -Task 15
Console.WriteLine("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
  case  1: Console.WriteLine("Понедельник"); break;
  case  2: Console.WriteLine("Вторник"); break;
  case  3: Console.WriteLine("Среда"); break;
  case  4: Console.WriteLine("Четверг"); break;
  case  5: Console.WriteLine("Пятница"); break;
  case  6: Console.WriteLine("Выходной"); break;
  case  7: Console.WriteLine("Выходной"); break;
}
Console.ReadKey();
