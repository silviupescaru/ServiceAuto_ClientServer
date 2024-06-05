using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Domain
{
    public class Car
    {
        protected uint carID;
        protected string owner;
        protected string brand;
        protected string color;
        protected string fuel;
        protected int year;
        protected string engineNo;
        protected string plateNo;
        protected string defect;
        protected float repairCost;
        protected bool repaired;

        public Car()
        {
            this.carID = 1;
            this.owner = "mike";
            this.brand = "Nissan Qashqai";
            this.color = "Gray";
            this.fuel = "Diesel";
            this.year = 2015;
            this.engineNo = "K9K";
            this.plateNo = "OT17PSM";
            this.defect = "Sunroof";
            this.repairCost = 150;
            this.repaired = false;
        }

        public Car(uint carID, string owner, string brand, string color, string fuel, int year, string engineNo, string plateNo, string defect, float repairCost, bool repaired)
        {
            this.carID = carID;
            this.owner = owner;
            this.brand = brand;
            this.color = color;
            this.fuel = fuel;
            this.year = year;
            this.engineNo = engineNo;
            this.plateNo = plateNo;
            this.defect = defect;
            this.repairCost = repairCost;
            this.repaired = repaired;
        }


        public Car(Car car)
        {
            this.carID = car.carID;
            this.owner = car.owner;
            this.brand = car.brand;
            this.color = car.color;
            this.fuel = car.fuel;
            this.year = car.year;
            this.engineNo = car.engineNo;
            this.plateNo = car.plateNo;
            this.defect = car.defect;
            this.repairCost = car.repairCost;
            this.repaired= car.repaired;
        }

        public uint CarID
        {
            get { return this.carID; }
            set { this.carID = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string EngineNo
        {
            get { return this.engineNo; }
            set { this.engineNo = value; }
        }

        public string PlateNo
        {
            get { return this.plateNo; }
            set { this.plateNo = value; }
        }

        public string Defect
        {
            get { return this.defect; }
            set { this.defect = value; }
        }

        public float RepairCost
        {
            get { return this.repairCost; }
            set { this.repairCost = value; }
        }

        public bool Repaired
        {
            get { return this.repaired; }
            set { this.repaired = value; }
        }

        public override string ToString()
        {
            string s = "Owner: " + this.owner;
            s += "\nBrand: " + this.brand;
            s += "\nColor: " + this.color;
            s += "\nFuel: " + this.fuel;
            return s;
        }
    }
}
