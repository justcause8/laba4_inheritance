using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba4_inheritance
{
    public class Transport {

        public static Random rnd = new Random();

        public virtual String GetInfo()
        {
            return "Я транспорт";
        }
    }

    // виды велосипедов
    public enum BicycleType { mountain, urban, children};
    public class Bicycle : Transport{
        public double wheelRadius = 0;
        public BicycleType type = BicycleType.mountain;

        public override String GetInfo()
        {
            var str = "Я велосипед";
            str += String.Format("\nРадиус колеса: {0}", this.wheelRadius);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }

        public static Bicycle Generate()
        {
            return new Bicycle
            {
                wheelRadius = rnd.Next() % 20, // диаметр от 0 до 20
            };
        }
    }

    // виды автомобилей
    public enum CarsType { bus, truck, SUV, car };
    public class Cars : Transport {
        public double engineCapacity = 0;
        public double numberOfDoors = 0;
        public CarsType type = CarsType.bus;

        public override String GetInfo()
        {
            var str = "Я автомобиль";
            str += String.Format("\nОбъем двигателя: {0}", this.engineCapacity);
            str += String.Format("\nКол-во дверей: {0}", this.numberOfDoors);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }

        public static Cars Generate()
        {
            return new Cars
            {
                engineCapacity = rnd.Next() % 10, // объем двигателя от 0 до 10
                numberOfDoors = rnd.Next() % 6, // кол-во дверей от 1 до 6
            };
        }
    }

    // самолет
    public class Plane : Transport {
        public string typeEngene = "";
        public double maxHeight = 0;

        public override String GetInfo()
        {
            var str = "Я самолет";
            str += String.Format("\nТип двигателя: {0}", this.typeEngene);
            str += String.Format("\nМаксимальная высота: {0}", this.maxHeight);
            return str;
        }

        public static Plane Generate()
        {
            var engineTypes = new string[] { "ДВС", "ВРД", "ТРД", "ПВРД", "ТВД", "ТВВД" };
            int index = rnd.Next(engineTypes.Length);
            return new Plane
            {
                typeEngene = engineTypes[index],
                maxHeight = rnd.Next() % 10000,
            };
        }
    }
    
}
