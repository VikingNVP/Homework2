// Задача 13
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 100){
    Console.WriteLine("Третья цифра = 0");
}
if(a < 100){
    Console.WriteLine("Третьего числа нет");   
}else if(a > 100){
    int result = FindThirdValue(a);
    Console.WriteLine("Третья цифра = " + result);
}


int FindThirdValue(int a)             
{
    while(a > 1000){
        a = a / 10;
    }
    int result = a % 10; 
    return result;
}
