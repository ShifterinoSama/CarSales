using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoSWUkol
{
    
    class Car
    {
        public string ModelName { get; set; }
        public DateTime SellDate { get; set; }
        public decimal Price { get; set; }
        public decimal DPH { get; set; }
        public Car()
        {

        }
        public decimal GetPriceWithDPH()
        {
            decimal priceWithDPH = (Price / 100 * DPH) + Price;
            return priceWithDPH;

        }


    }
}
