using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SabarovDA.Sprint5.Task6.V2.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint5.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #5 | Выполнил: Сабаров Д. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант 2                                                               *");
            Console.WriteLine("* Выполнил: Сабаров Дмитрий Александрович | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V2.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и    *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Найти   *");
            Console.WriteLine("* количество русских букв в заданной строке.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"D:\DataSprint5\InPutDataFileTask6V2.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.LoadFromDataFile(path));


            Console.ReadKey();
        }
    }
}
