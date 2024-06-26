﻿using ServiceAuto_Server.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using ServiceAuto_Server.Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Repository
{
    public class CarRepository : ICarRepository
    {
        private Repository repository;

        public CarRepository()
        {
            this.repository = Repository.GetInstance();
        }

        public bool AddCar(Car car)
        {
            string commandSQL = "insert into Car values('";
            commandSQL += car.Owner + "','" + car.Brand;
            commandSQL += "','" + car.Color + "','" + car.Fuel;
            commandSQL += "','" + car.Year + "','" + car.EngineNo;
            commandSQL += "','" + car.PlateNo + "','" + car.Defect;
            commandSQL += "','" + car.RepairCost + "','" + car.Repaired;
            commandSQL += "')";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool DeleteCar(uint id)
        {
            string commandSQL = "delete from Car where carID = '" + id + "'";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool UpdateCar(Car car)
        {
            string commandSQL = "update [Car] set [owner] = '";
            commandSQL += car.Owner + "', [brand] = '" + car.Brand;
            commandSQL += "', [color] = '" + car.Color;
            commandSQL += "', [fuel] = '" + car.Fuel;
            commandSQL += "', [year] = '" + car.Year;
            commandSQL += "', [engineNo] = '" + car.EngineNo;
            commandSQL += "', [plateNo] = '" + car.PlateNo;
            commandSQL += "', [defect] = '" + car.Defect;
            commandSQL += "', [repairCost] = '" + car.RepairCost;
            commandSQL += "', [repaired] = '" + car.Repaired;
            commandSQL += "' where [carID] = '" + car.CarID + "'";
            return this.repository.CommandSQL(commandSQL);
        }

        public DataTable EmptyTable()
        {
            string selectSQL = "Select * from Car where 1=0";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            return carTable;
        }

        public DataTable CarTable()
        {
            string selectSQL = "Select * from Car order by carID";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            return carTable;
        }

        public DataTable CarTableBrandFuel()
        {
            string selectSQL = "Select * from [Car] order by [brand], [fuel]";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            return carTable;
        }

        public List<Car> CarList()
        {
            DataTable carTable = this.CarTable();
            if (carTable == null)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_BrandFuel()
        {
            string selectSQL = "Select * from [Car] order by [brand], [fuel]";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Owner(string owner)
        {
            string selectSQL = "Select * from [Car] where [owner] ='";
            selectSQL += owner;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Brand(string brand)
        {
            string selectSQL = "Select * from [Car] where [brand] ='";
            selectSQL += brand;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Color(string color)
        {
            string selectSQL = "Select * from [Car] where [color] ='";
            selectSQL += color;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Year(int year)
        {
            string selectSQL = "Select * from [Car] where [year] ='";
            selectSQL += year;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Fuel(string fuel)
        {
            string selectSQL = "Select * from [Car] where [fuel] ='";
            selectSQL += fuel + "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public Car SearchCarByID(string id)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                string searchSQL = "Select * from Car where carID = " + ID;
                DataTable carTable = this.repository.GetTable(searchSQL);
                if (carTable == null || carTable.Rows.Count == 0)
                    return null;
                DataRow dr = carTable.Rows[0];
                return this.convertToCar(dr);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Car> SearchCarByOwner(string owner)
        {
            string selectSQL = "Select * from Car where owner = '" + owner + "'";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> SearchCarByPlate(string plate)
        {
            string selectSQL = "Select * from Car where plateNo = '" + plate + "'";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> SearchCarByEngineNo(string engineNo)
        {
            string selectSQL = "Select * from Car where engineNo = '" + engineNo + "'";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        private Car convertToCar(DataRow dataRow)
        {
            int id = (int)dataRow["carID"];
            return new Car((uint)id, (string)dataRow["owner"], (string)dataRow["brand"], (string)dataRow["color"], (string)dataRow["fuel"], Convert.ToInt32(dataRow["year"]), (string)dataRow["engineNo"], (string)dataRow["plateNo"], (string)dataRow["defect"], (float)Convert.ToDouble(dataRow["repairCost"]), Convert.ToBoolean(dataRow["repaired"]));
        }

    }
}
