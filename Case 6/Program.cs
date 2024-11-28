// See https://aka.ms/new-console-template for more information

     
Console.WriteLine("1-децметр, 2-километр, 3-метр, 4-миллиметр, 5-сантиметр");
var num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите число");
var number = Convert.ToInt32(Console.ReadLine());       
double result = 0;
switch (num)
{
        case 1:
                result = number*10;
                break;
        case 2 :
                result = number*1000;
                break;
        case 3:
                result = number;
                break;
        case 4:
                result = number/0.001;
                break;
        case 5:
                result = number*100;
                break;
        default:
                Console.WriteLine("Wrong input");
                return;
}
Console.WriteLine($"Длина в метрах:{result}");