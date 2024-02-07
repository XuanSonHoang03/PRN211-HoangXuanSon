using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        Car GetCarByID(int carID);
        IEnumerable<Car> GetCarList();
        void insertCar(Car car);
        void updateCar(Car car);
        void deleteCar(int id);
    }
}
