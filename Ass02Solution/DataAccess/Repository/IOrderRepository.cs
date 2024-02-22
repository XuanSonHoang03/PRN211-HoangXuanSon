using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<OrderObject> GetOrders();
        OrderObject GetOrderById(int orderId);
        void insert(OrderObject orderObject);
        void delete(int orderId);
        int InsertAndGetOrderId(OrderObject orderObject);
    }
}
