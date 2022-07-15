using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoSWUkol
{
    class CarDataHandler
    {
        public List<Car> Cars { get; set; }
        public List<CarTableData> CarTableDatas { get; set; } = new();
        public List<CarTableData> GetCarsSoldAtWeekend()
        {
            
            foreach (Car car in Cars.Where(c => c.SellDate.DayOfWeek is DayOfWeek.Sunday or DayOfWeek.Saturday))
            {

                if (!CarTableDatas.Select(x => x.ModelName).Contains(car.ModelName))
                {
                    CarTableDatas.Add(new CarTableData
                    {
                        ModelName = car.ModelName,
                        TotalPrice = car.Price,
                        TotalPriceWithDph = car.GetPriceWithDPH()
                    });
                }
                else
                {
                    foreach (CarTableData carTableData in CarTableDatas)
                    {
                        if (carTableData.ModelName == car.ModelName)
                        {
                            carTableData.TotalPrice += car.Price;
                            carTableData.TotalPriceWithDph += car.GetPriceWithDPH();
                        }

                    }
                }
            }
            return CarTableDatas;
        }
    }
}
