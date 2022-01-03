using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
//В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
//- метод получает входным параметром переменную типа double;
//- метод возвращает значение типа double, которое является результатом вычисления.
//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//- длину окружности по формуле D = 2 * π * R;
//- площадь круга по формуле S = π* R²;
//- объем шара.Формула V = 4 / 3 * π * R³.
//Методы должны быть объявлены как статические.

        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус R");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = Circumerence;
            double s = myDelegate(r);
            Console.WriteLine("Длина окружности = {0:0.00}", s);

            myDelegate = CircleArea;
            s = myDelegate(r);
            Console.WriteLine("   Площадь круга = {0:0.000}", s);

            myDelegate = SphereVolume;
            s = myDelegate(r);
            Console.WriteLine("      Объем шара = {0:0.0000}", s);

            Console.ReadKey();
        }
        static double Circumerence(double r)
        {
            return Math.PI * r * 2;
        }
        static double CircleArea(double r) => Math.PI * Math.Pow(r, 2);
        static double SphereVolume(double r) => Math.PI * Math.Pow(r, 3) * 4 / 3;

    }
}
