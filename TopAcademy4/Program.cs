using System;
using System.Security.Cryptography.X509Certificates;

namespace TopAcademy4
{
    class Person { }
    class User: Person { }

    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5.7;
            double y = 6.4;
            /*выполняется явное приведение значения переменной,
            имеющей тип данных double, к типу int*/
            int A = (int)x;
            /*выполняется явное приведение результата
            выражения, имеющего тип данных double, к типу int*/
            int B = (int)(x + y);
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
    }
/*Вывод
 c format:     99 989,99 ?
D format: 000099999
E format: 9,998999E+004
f format: 99989,99
G format: 99989,987
N format:       99 999,00
P format: 9 998 998,70 %
X format: 1869F
x format: 1869f

*/