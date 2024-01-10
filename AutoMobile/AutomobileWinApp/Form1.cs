using DataAccess;
using BussinessObject;
using Repository;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public ICarRepository carRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // false: insert - true: update
        public Car CarInfo { get; set; }
        public frmCarDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedItem = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //update mode
            {
                //show car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text),
                };
                if (InsertOrUpdate == false)
                {
                    carRepository.InsertCar(car);
                }
                else
                {
                    carRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
