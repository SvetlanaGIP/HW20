using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20
{
    class Program
    {
        // В приложении объявить тип делегата, который ссылается на метод.
        // Требования к сигнатуре метода следующие:
        //-       метод получает входным параметром переменную типа double;
        //-       метод возвращает значение типа double,
        //которое является результатом вычисления.
        //Реализовать вызов методов с помощью делегата,
        //которые получают радиус R и вычисляют:
        //-       длину окружности по формуле D = 2 * π * R;
        //-       площадь круга по формуле S = π* R²;
        //-       объем шара.Формула V = 4 / 3 * π * R³.
        //Методы должны быть объявлены как статические.
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //int r = myDelegate(2, 10);
            //Console.WriteLine(r);

            //myDelegate = PowerBA;
            //r = myDelegate(2, 10);
            //Console.WriteLine(r);

            MyDelegate myDelegate = Lenght;
            myDelegate += Area;
            myDelegate += Volume;
            myDelegate(5);
            Console.ReadKey();
        }

        static double Lenght(double R)
        {
            double D = Math.PI*2*R;
            Console.WriteLine(D);
            return D;
        }
        static double Area(double R)
        {
            double S = Math.PI*Math.Pow(R, 2);
            Console.WriteLine(S);
            return S;
        }
        static double Volume(double R)
        {
            double V = 4/3*Math.Pow(R, 3);
            Console.WriteLine(V);
            return V;
        }
    }
}
