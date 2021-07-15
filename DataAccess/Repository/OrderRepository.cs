﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<TblOrder> GetOrders() => OrderDAO.Instance.GetOrderList();
        public void AddOrder(TblOrder or) => OrderDAO.Instance.AddNew(or);
    }
}
