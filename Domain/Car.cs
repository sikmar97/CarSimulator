using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
   abstract class Car
    {
        private string brand;
        private string model;
        private string numPlate;
        private int velocity;

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

        public int Velocity
        {
            set
            {
                velocity = value;
            }
            get
            {
                return velocity;
            }
        }


        public void SetNumPlate(string value)
        {
            if (value.Length > 7)
            {
                numPlate = value.Substring(0, 7);
            }
            else
            {
                numPlate = value;
            }
        }

        public abstract void Accelerate(int sec);
    }
}
   
