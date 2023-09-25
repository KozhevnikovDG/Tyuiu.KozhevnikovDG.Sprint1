using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KozhevnikovDG.Sprint1.Task3.V2.Lin;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int amountNotebook;
            Console.WriteLine("Введите значения amountNotebook: ");
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            double priceNotebook;
            Console.WriteLine("Введите значения priceNotebook: ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            int amountPencil;
            Console.WriteLine("Введите значения amountPencil: ");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            double pricePencil;
            Console.WriteLine("Введите значения pricePencil: ");
            pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Стоимость  покупки = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));

            Console.ReadLine();
        }
    }
}
