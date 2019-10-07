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
            set
            {
                numPlate = value; 
            }
            get
            {
                return numPlate;
            }
        }


        public void SetNumPlate(string value)
        {
            if (value.Length > 6)
            {
                numPlate = value.Substring(0, 6);
            }
            else
            {
                numPlate = value;
            }
        }
    }
}
   
