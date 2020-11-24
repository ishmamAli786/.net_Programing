using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_IT_7
{
    class Class1
    {
        private int speed, size, weight, enginePower,range;
        private string color,wheals,fuel,gearBox, breaks;


        public int Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }
        public int Size
        {
            set
            {
                size = value;
            }
            get
            {
                return size;
            }
        }
        public int Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        public int EnginePower
        {
            set
            {
                enginePower = value;
            }
            get
            {
                return enginePower;
            }
        }
        public string Breaks
        {
            set
            {
                breaks = value;
            }
            get
            {
                return breaks;
            }
        }
        public int Range
        {
            set
            {
                range = value;
            }
            get
            {
                return range;
            }
        }
        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        public string Wheals
        {
            set
            {
                wheals = value;
            }
            get
            {
                return wheals;
            }
        }
        public string Fuel
        {
            set
            {
                fuel = value;
            }
            get
            {
                return fuel;
            }
        }
        public string GearBox
        {
            set
            {
                gearBox = value;
            }
            get
            {
                return gearBox;
            }
        }
    }
}
