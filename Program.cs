using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_design
{
    class Program
    {
        static void Main(string[] args)
        {

            ICar car = new ProxyCar(new Driver(17));
            car.DriveCar();

            car = new ProxyCar(new Driver(27));
            car.DriveCar();
        }
    }
}
