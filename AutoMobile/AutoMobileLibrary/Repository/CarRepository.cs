using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int CarID)
        {
            CarDBContext.Instance.Remove(CarID);
        }

        public Car getCarByID(int CarID)
        {
            return CarDBContext.Instance.getCarByID(CarID);
        }

        public IEnumerable<Car> GetCars()
        {
            return CarDBContext.Instance.GetCarList;
        }

        public void InsertCar(Car car)
        {
            CarDBContext.Instance.AddNew(car);
        }

        public void UpdateCar(Car car)
        {
            CarDBContext.Instance.Update(car);
        }
    }
}
