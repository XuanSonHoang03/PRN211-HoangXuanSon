using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMyOrder : Form
    {
        public MemberObject memberObject { get; set; }
        public IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public frmMyOrder()
        {
            InitializeComponent();
        }

        private void frmMyOrder_Load(object sender, EventArgs e)
        {
            dgvMyOrder.DataSource = orderDetailRepository.GetOrdersDetail();
            List<OrderDetailObject> list = orderDetailRepository.GetOrdersDetail();
            foreach(OrderDetailObject orderDetail in list)
            {
                tbTotalOrder.Text = orderDetail.Quantity * orderDetail.UnitPrice + "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
