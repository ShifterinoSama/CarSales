using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TescoSWUkol
{
    class DataHandler
    {

        public string SelectFile()
        {
            OpenFileDialog dialog = new()
            {
                FileName = "Document",
                DefaultExt = ".xml",
                Filter = "XML documents (.xml)|*.xml"
            };

            bool? result = dialog.ShowDialog();

            return result == true ? dialog.FileName : string.Empty;
        }

        public List<Car> ReadAndSaveData(string path)
        {
            XmlTextReader reader = new(path);
            List<Car> cars = new();
            bool createNewObject = false;
            string modelName = string.Empty;
            DateTime sellDate = DateTime.UtcNow;
            decimal price = decimal.Zero;
            decimal dph = decimal.Zero;



            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (reader.Name)
                        {
                            case "Auto":
                                createNewObject = true;
                                break;
                            case "Model":
                                modelName = reader.ReadInnerXml();
                                break;
                            case "Prodano":
                                sellDate = DateTime.Parse(reader.ReadInnerXml());
                                break;
                            case "Cena":
                                price = decimal.Parse(reader.ReadInnerXml());
                                break;
                            case "DPH":
                                dph = decimal.Parse(reader.ReadInnerXml());
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "Auto")
                        {
                            if (createNewObject)
                            {
                                cars.Add(new Car()
                                {
                                    ModelName = modelName,
                                    SellDate = sellDate,
                                    Price = price,
                                    DPH = dph
                                });
                            }

                            createNewObject = false;
                            modelName = string.Empty;
                            price = decimal.Zero;
                            dph = decimal.Zero;
                            sellDate = DateTime.UtcNow;
                        }
                        break;
                }
            }
            return cars;
        }

    }
}
