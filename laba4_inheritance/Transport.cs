using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_inheritance
{
    public class Transport { }

    // виды велосипедов
    public enum BicycleType { mountain, urban, children};
    public class Bicycle {
        public double wheelRadius = 0;
        public BicycleType type = BicycleType.mountain; // тип
    }

    // виды автомобилей
    public enum CarsType { bus, truck, SUV, car };
    public class Cars {
        public double engineCapacity = 0;
        public double numberOfDoors = 0;
        public CarsType type = CarsType.bus;
    }

    // самолет
    public class Plane {
        public string typeEngene = "";
        public double maxHeight = 0;
    }
    
}
