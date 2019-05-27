using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Classes
{
    class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver Driver { get; set; }

        public Car (string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            int speed = driver.Skill * Speed;
            return speed;
        }
    }
}
