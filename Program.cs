using System;
namespace Mengi
{
    class Program
    {
        //  функция выборки городов
        static public bool Fun(int x, int y)
        {
            int pointX = 36, pointY = 52;
            int radius = 54;
            bool check = false;
            //  услоивие НЕ попадания в область; первая часть с рандомными координатами должна быть больше чем вторая часть
            if (Math.Pow((x - pointX), 2) + Math.Pow((y - pointY), 2) > Math.Pow(radius, 2))
                check = false;
            else check = true;
            return check;
        }
        static void Main(string[] args)
        {
            //  массив с координатами городов;
            //  первая строка - Х, вторая строка - У
            int[,] arr = new int[2, 12] { { 20, 56, 56, 44, 82, 68, 56, 88, 36, 40, 37, 38},
                                          { 76, 46, 14, 73, 65, 98, 78, 32, 52, 98, 1, 65 } };
            int count = 0;
            //  проходимся в цикле по всем городам
            for(int i = 0; i < 12; i++)
            {
                if( Fun(arr[0,i], arr[1,i]) )
                {
                    Console.WriteLine($"Город {count + 1} с координатами: {arr[0, i]}, {arr[1, i]} входит в область действия!");
                }
                count++;
            }
        }
    }
}
