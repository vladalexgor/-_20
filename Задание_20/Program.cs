using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        - метод получает входным параметром переменную типа double;
        - метод возвращает значение типа double, которое является результатом вычисления.
        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        - длину окружности по формуле D = 2 * π * R;
        - площадь круга по формуле S = π* R²;
        - объем шара.Формула V = 4 / 3 * π * R³.
        Методы должны быть объявлены как статические.*/
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = LengthCircle;
            Console.WriteLine("Введите значение радиуса:");
            double r = Convert.ToDouble(Console.ReadLine());
            if (myDelegate != null)
            {
                Console.WriteLine("Длина окружности равна: D = {0:f2}", myDelegate(r));
            }
            myDelegate = AreaCircle;
            if (myDelegate != null)
            {
                Console.WriteLine("Площадь круга равна: S = {0:f2}", myDelegate(r));
            }
            myDelegate = VolumeSphere;
            if (myDelegate != null)
            {
                Console.WriteLine("Объем шара равен: V = {0:f2}", myDelegate(r));
            }
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        static double LengthCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        static double AreaCircle(double r)
        {
            return Math.PI * r * r;
        }
        static double VolumeSphere(double r)
        {
            return (4 * Math.PI * Math.Pow(r, 3))/3;
        }
    }
}
