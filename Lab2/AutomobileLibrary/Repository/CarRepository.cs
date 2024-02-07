using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarDBContext.Instance.getCarByID(carID);
        public IEnumerable<Car> GetCarList() => CarDBContext.Instance.GetCarList();
        public void insertCar(Car car) => CarDBContext.Instance.AddCar(car);
        public void updateCar(Car car) => CarDBContext.Instance.UpdateCar(car);
        public void deleteCar(int carID) => CarDBContext.Instance.remove(carID);
    }
}
