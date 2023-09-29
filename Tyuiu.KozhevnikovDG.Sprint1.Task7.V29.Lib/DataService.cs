using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozhevnikovDG.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            double res = x - (Math.Pow(Math.Cos(x), 3)) / (x * y - 3) + (Math.Pow(Math.Sin(x), 5)) / (x * y + 5);
            return Math.Round(res, 3); 
        }
    }
}
