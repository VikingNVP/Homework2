// Задача 10
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 100 || a > 999){
    Console.WriteLine("Ошибка");
    return;
}
int result = DeleteValues(a);
Console.WriteLine(result);



int DeleteValues(int a)
{
    return a % 100 / 10;
}
