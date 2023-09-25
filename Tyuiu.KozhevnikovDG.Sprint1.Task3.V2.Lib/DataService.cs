using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.KozhevnikovDG.Sprint1.Task3.V2.Lin
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            return (priceNotebook * amountNotebook) + (pricePencil * amountPencil);
        }
    }
}
