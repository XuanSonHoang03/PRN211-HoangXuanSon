using DataAccess;
using Repository;
using BussinessObject;
using AutomobileWinApp;
using BussinessObject;
namespace frmCarManagement
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        //create data source
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
        }


        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
            dgvCar.CellDoubleClick += dgvCar_CellDoubleClick;
        }

        private void dgvCar_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Update Car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                carRepository = carRepository,
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //set focus car updated
                source.Position = source.Count - 1;
            }
        }

        private void LoadCarList()
        {
            var cars = carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManufacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dgvCar.DataSource = null;
                dgvCar.DataSource = source;

                if (cars.Count() == 0)
                {
                    ClearText();
                    btDelete.Enabled = false;
                }
                else
                {
                    btDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Car List");
            }

        }
        private void ClearText()
        {
            txtCarID.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }
        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }
            return car;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Add Car",
                InsertOrUpdate = false,
                carRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }
    }
}
