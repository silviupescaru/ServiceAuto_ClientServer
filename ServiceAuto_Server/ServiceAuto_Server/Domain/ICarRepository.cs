using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Domain
{
    public interface ICarRepository
    {
        bool AddCar(Car car);
        bool DeleteCar(uint id);
        bool UpdateCar(Car car);

    }
}
