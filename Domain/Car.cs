using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class Car
    {
        private string brand;
        private string model;
        private string numPlate;


        public Car (string brand, string model, string numPlate)
        {
            this.brand = brand;
            this.model = model;
            this.numPlate = numPlate;
        }

        public string Brand
        {
            get
            {
                return brand;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
        }
        public string NumPlate
        {
            get
            {
                return numPlate;
            }
        }
    }
}
