using ServiceAuto_Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Repository;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceAuto_Server.Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class CarService : ICarService
    {
        private ICarRepository iCarRepository;

        public CarService()
        {
            this.iCarRepository = new CarRepository();
        }

        public bool AddCar(Car car)
        {
            return this.iCarRepository.AddCar(car);
        }

        public bool DeleteCar(uint id)
        {
            return this.iCarRepository.DeleteCar(id);
        }

        public bool UpdateCar(Car car)
        {
            return this.iCarRepository.UpdateCar(car);
        }

        public DataTable EmptyTable()
        {
            return this.iCarRepository.EmptyTable();
        }

        public DataTable CarTable()
        {
            return this.iCarRepository.CarTable();
        }

        public DataTable CarTableBrandFuel()
        {
            return this.iCarRepository.CarTableBrandFuel();
        }

        public List<Car> CarList()
        {
            return this.iCarRepository.CarList();
        }

        public List<Car> CarList_BrandFuel() 
        {
            return this.iCarRepository.CarList_BrandFuel();
        }

        public List<Car> CarList_Owner(string owner)
        {
            return this.iCarRepository.CarList_Owner(owner);
        }

        public List<Car> CarList_Brand(string brand)
        {
            return this.iCarRepository.CarList_Brand(brand);
        }

        public List<Car> CarList_Color(string color)
        {
            return this.iCarRepository.CarList_Color(color);
        }

        public List<Car> CarList_Fuel(string fuel)
        {
            return this.iCarRepository.CarList_Fuel(fuel);
        }

        public List<Car> CarList_Year(int year)
        {
            return this.iCarRepository.CarList_Year(year);
        }

        public Car SearchCarByID(string id)
        {
            return this.iCarRepository.SearchCarByID(id);
        }

        public List<Car> SearchCarByOwner(string owner)
        {
            return this.iCarRepository.SearchCarByOwner(owner); 
        }

        public List<Car> SearchCarByPlate(string plate)
        {
            return this.iCarRepository.SearchCarByPlate(plate);
        }

        public List<Car> SearchCarByEngineNo(string engineNo)
        {
            return this.iCarRepository.SearchCarByEngineNo(engineNo);
        }

    }
}
