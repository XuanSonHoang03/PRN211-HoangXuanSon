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
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class frmCart : Form
    {
        public IProductRepository productRepository = new ProductRepository();
        private List<ProductObject> productsList;
        private List<ProductObject> productsListSearch;
        public MemberObject memberObject { get; set; }
        BindingSource bindingSource;
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            LoadProductList();
            dgvProduct.CellDoubleClick += DgvProduct_CellDoubleClick;
        }

        private void LoadProductList()
        {
            try
            {
                var productList = productRepository.GetProductObject();

                if (productList != null && productList.Count > 0)
                {
                    this.productsList = productList;

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = productsList;

                    

                    dgvProduct.DataSource = null;
                    dgvProduct.DataSource = bindingSource;

                    btFilter.Enabled = true;
                }
                else
                {
                    btFilter.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when load list");
            }
        }

        private void DgvProduct_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmProductOrder frmProductOrder = new frmProductOrder()
            {
                memberObject = memberObject,
                ProductObject = productsList[e.RowIndex],
                Text = "Order product"
            };
            if (frmProductOrder.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void btViewCart_Click(object sender, EventArgs e)
        {
           frmMyOrder frmMyOrder = new frmMyOrder()
           {
                memberObject = memberObject
            };
            this.Hide();
            frmMyOrder.ShowDialog();
            this.Show();
        }
    }
}
