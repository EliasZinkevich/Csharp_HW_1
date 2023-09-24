// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Мил Государь, напиши первшее число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ну, теперича и второе ляпни");
int B = Convert.ToInt32(Console.ReadLine());
if(A == B)
{Console.WriteLine("Чой-то ты мене дуришь, одинаковые они!");}
else if(A > B)
{Console.WriteLine("Но так первшее поболе будет");}
else 
{Console.WriteLine("Как ни крути, а второе-то бооольше");}