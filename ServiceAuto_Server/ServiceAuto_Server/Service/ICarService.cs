using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Domain;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceAuto_Server.Service
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        bool AddCar(Car car);

        [OperationContract]
        bool DeleteCar(uint id);

        [OperationContract]
        bool UpdateCar(Car car);

        [OperationContract]
        DataTable CarTable();

        [OperationContract]
        List<Car> CarList();

        [OperationContract]
        List<Car> CarList_BrandFuel();

        [OperationContract]
        List<Car> CarList_Owner(string owner);

        [OperationContract]
        List<Car> CarList_Brand(string brand);

        [OperationContract]
        List<Car> CarList_Color(string color);

        [OperationContract]
        List<Car> CarList_Fuel(string fuel);

        [OperationContract]
        Car SearchCarByID(string id);

        [OperationContract]
        List<Car> SearchCarByOwner(string owner);

        [OperationContract]
        List<Car> SearchCarByPlate(string plate);

        [OperationContract]
        List<Car> SearchCarByEngineNo(string engineNo);

    }
}
