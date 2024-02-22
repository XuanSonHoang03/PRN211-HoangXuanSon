using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void delete(int orderId)
        {
            OrderDAO.Instance.delete(orderId);
        }

        public OrderObject GetOrderById(int orderId)
        {
            return OrderDAO.Instance.GetOrderById(orderId);
        }

        public List<OrderObject> GetOrders()
        {
            return OrderDAO.Instance.GetAllOrder();
        }

        public void insert(OrderObject orderObject)
        {
            OrderDAO.Instance.InsertOrder(orderObject);
        }

        public int InsertAndGetOrderId(OrderObject orderObject)
        {
            return OrderDAO.Instance.InsertAndGetOrderId(orderObject);
        }
    }
}
