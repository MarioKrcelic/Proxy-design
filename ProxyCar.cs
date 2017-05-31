using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_design
{
    public class ProxyCar : ICar
    {
        private Driver driver;
        private ICar realCar;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new RealCar();
        }

        public void DriveCar()
        {
            if (driver.Age <= 17)
            {
                Console.WriteLine("Sorry, the driver is too young to drive.");
            }
            else
            {
                this.realCar.DriveCar();
            }
        }
    }
}
