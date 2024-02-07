using AutomobileLibrary.BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        //using singlepattern to create a single instance of the class
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }   
        }
        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string sql = "SELECT * FROM Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    var car = new Car
                    {
                        carID = Convert.ToInt32(dataReader["CarId"]),
                        carName = dataReader["carName"].ToString(),
                        manufacturer = dataReader["Manufacturer"].ToString(),
                        price = Convert.ToDouble(dataReader["Price"]),
                        releaseYear = Convert.ToInt32(dataReader["releaseYear"])
                    };
                    cars.Add(car);
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataProvider.closeConnection(connection);
            }
            return cars;
        }
        public Car getCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string sql = "SELECT * FROM Cars WHERE CarId = @CarId";
            try
            {
                var param = dataProvider.CreateParameter("@CarId", 4, carID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection, param);
                if(dataReader.Read())
                {
                    car = new Car
                    {
                        carID = Convert.ToInt32(dataReader["CarId"]),
                        carName = dataReader["carName"].ToString(),
                        manufacturer = dataReader["Manufacturer"].ToString(),
                        price = Convert.ToDouble(dataReader["Price"]),
                        releaseYear = Convert.ToInt32(dataReader["releaseYear"])
                    };
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataProvider.closeConnection(connection);
            }
            return car;
        }
        public void AddCar(Car car)
        {
            try
            {
                Car car1 = getCarByID(car.carID);
                if (car1 == null)
                {
                    string sql = "INSERT INTO Cars (CarID, CarName, Manufacturer, Price, ReleaseYear) VALUES (@carID, @CarName, @Manufacturer, @Price, @ReleaseYear)";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@carID", 4, car.carID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@CarName", 50, car.carName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.manufacturer, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Price", 8, car.price, DbType.Double));
                    parameter.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.releaseYear, DbType.Int32));
                    dataProvider.insert(sql, CommandType.Text, out connection, parameter.ToArray());

                } else
                {
                    throw new Exception("Car already exists");
                }
            } catch(Exception ex) { 
                throw new Exception(ex.Message); 
            } finally { 
                dataProvider.closeConnection(connection);
            }
        }
        public void UpdateCar(Car car)
        {
            try
            {
                Car car1 = getCarByID(car.carID);
                if (car1 != null)
                {
                    string sql = "UPDATE Cars SET CarName = @CarName, Manufacturer = @Manufacturer, Price = @Price, ReleaseYear = @ReleaseYear WHERE CarId = @CarId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@carID", 4, car.carID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@CarName", 50, car.carName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.manufacturer, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Price", 8, car.price, DbType.Double));
                    parameter.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.releaseYear, DbType.Int32));
                    dataProvider.insert(sql, CommandType.Text, out connection, parameter.ToArray());
                } else
                {
                    throw new Exception("Car does not exist");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataProvider.closeConnection(connection);
            }
        }
        public void remove(int carID)
        {
            try
            {
                Car carDel = getCarByID(carID);
                if(carDel != null)
                {
                    string sql = "DELETE FROM Cars WHERE CarId = @CarId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@carID", 4, carID, DbType.Int32));
                    dataProvider.delete(sql, CommandType.Text, out connection, parameter.ToArray());
                } else
                {
                    throw new Exception("Car does not exist");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataProvider.closeConnection(connection);
            }
        }
    }
}
