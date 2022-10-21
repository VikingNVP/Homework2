// Задача 15
Console.Clear();
Console.WriteLine("Введите число дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 5 || a == 5){
    Console.WriteLine("Будний день");
}else if(a > 5){
    Console.WriteLine("Выходной");
} 


switch (a)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
}
   