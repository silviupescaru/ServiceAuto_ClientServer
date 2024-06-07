using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceAuto_Server.Domain
{
    public interface ICarRepository
    {
        bool AddCar(Car car);
        bool DeleteCar(uint id);
        bool UpdateCar(Car car);
        DataTable EmptyTable();
        DataTable CarTable();
        DataTable CarTableBrandFuel();
        List<Car> CarList();
        List<Car> CarList_BrandFuel();
        List<Car> CarList_Owner(string owner);
        List<Car> CarList_Brand(string brand);
        List<Car> CarList_Color(string color);
        List<Car> CarList_Fuel(string fuel);
        Car SearchCarByID(string id);
        List<Car> SearchCarByOwner(string owner);
        List<Car> SearchCarByPlate(string plate);
        List<Car> SearchCarByEngineNo(string engineNo);
    }
}
