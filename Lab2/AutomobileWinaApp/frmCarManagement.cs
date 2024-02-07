using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinaApp
{
    public partial class frmCarManagement : Form
    {
        ICarRepository CarRepository = new CarRepository();
        BindingSource source = new BindingSource();
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
            dgvDisplay.CellDoubleClick += dgvDisplay_CellDoubleClick;
        }

        private void dgvDisplay_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frm = new frmCarDetails
            {
                Text = "Update a car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                carRepository = CarRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }

        private void LoadCarList()
        {
            var car = CarRepository.GetCarList();
            try
            {
                source = new BindingSource();
                source.DataSource = car;

                tbID.DataBindings.Clear();
                tbName.DataBindings.Clear();
                tbYear.DataBindings.Clear();
                tbPrice.DataBindings.Clear();
                tbManufacturer.DataBindings.Clear();

                tbID.DataBindings.Add("Text", source, "carID");
                tbName.DataBindings.Add("Text", source, "carName");
                tbYear.DataBindings.Add("Text", source, "releaseYear");
                tbPrice.DataBindings.Add("Text", source, "price");
                tbManufacturer.DataBindings.Add("Text", source, "manufacturer");

                dgvDisplay.DataSource = source;

                if (car.Count() > 0)
                {
                    btDelete.Enabled = true;
                }
                else
                {
                    btDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    carID = int.Parse(tbID.Text),
                    carName = tbName.Text,
                    manufacturer = tbManufacturer.ToString(),
                    releaseYear = int.Parse(tbYear.Text),
                    price = double.Parse(tbPrice.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car object");
            }
            return car;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frm = new frmCarDetails
            {
                Text = "Add a new car",
                InsertOrUpdate = false,
                carRepository = CarRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = GetCarObject();
                CarRepository.deleteCar(car.carID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
