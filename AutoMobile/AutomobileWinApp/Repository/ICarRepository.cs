using DataAccess;
using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car getCarByID(int CarID);
        void InsertCar(Car car);
        void DeleteCar(int CarID);
        void UpdateCar(Car car);
    }
}
