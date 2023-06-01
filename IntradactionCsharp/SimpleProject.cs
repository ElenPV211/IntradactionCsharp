/*при помощи метода GetType() программа возвращает
тип данных литералов, демонстрируя действие
суффиксов*/
Console.WriteLine((10D).GetType()); /*выводит
в консоль: System.Double что соответствует типу
данных double*/
Console.WriteLine((10f).GetType()); /*выводит
в консоль: System.Single что соответствует типу
данных float*/
Console.WriteLine((10m).GetType()); /*выводит
в консоль: System.Decimal что соответствует типу
данных decimal*/
Console.WriteLine((10).GetType()); /*выводит
в консоль: System.Int32 что соответствует типу
данных int*/
Console.WriteLine((10L).GetType()); /*выводит
в консоль: System.Int64 что соответствует типу
данных long*/
Console.WriteLine((10UL).GetType()); /*выводит
в консоль: System.Uint64 что соответствует типу
данных ulong*/
Console.WriteLine(0xFF); /*выводит в консоль:
255 шестнадцатиричное число 0xFF соответствует
десятичному числу 255*/