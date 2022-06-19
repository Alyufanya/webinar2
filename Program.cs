//  - - - Task 9
//int number = new Random().Next(10, 100);//[10, 100)
//Console.WriteLine($"Наше случайное число = {number}");
//int digit1 = number / 10; //48 / 10 = 4
//int digit2 = number % 10; //48 % 10 = 8
//if (digit1 > digit2){
//    Console.WriteLine($"Цифра {digit1} наибольшая");
//}
//else {
////    Console.WriteLine($"Цифра {digit2} наибольшая");
//}
// - - - Task 11
//int number = new Random().Next(100, 999);
//Console.WriteLine($"Наше случайное число = {number}");
//int numberB = number / 100;
//int numberC = number / 10 % 10;
//int numberD = number % 10;
//int result = numberB * 10 + numberD;
//Console.WriteLine($"{result}");
// - - - Task 12
//Console.WriteLine("Введите первое число");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int mod = number1 % number2;
//if(mod == 0){
 //   Console.WriteLine("Первое число нацело делится на второе");
//}
//else{
//    Console.WriteLine($"Остаток от деления = {mod}");
//}
// -----Task 4
//Console.WriteLine("Введите первое число");
//int numberB = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int numberA = Convert.ToInt32(Console.ReadLine());
//if(numberB*numberB==numberA || numberA*numberA==numberB)
//{
//    Console.WriteLine("одно число является квадратом другого числа");
//}
//else{
//    Console.WriteLine("числа не являются квадратами друг друга");
//}
// - - -Task 5
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
//if(number > 99 && number < 1000)
//{
 //   Console.WriteLine(number%10);
//}
//else{
//    string number1=number.ToString();
//    Console.WriteLine(number1[2]);
//}
else{
    while(number>999)
    {
        number = number/10;
    }
Console.WriteLine(number%10);
}