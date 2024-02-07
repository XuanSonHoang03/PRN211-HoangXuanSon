using AutomobileLibrary.Repository;
using AutomobileLibrary.BusinessObject;

namespace AutomobileWinaApp
{
    public partial class frmCarDetails : Form
    {
        public ICarRepository carRepository = new CarRepository();
        public bool InsertOrUpdate { get; set; } // false: insert, true: update
        public Car CarInfo { get; set; }

        public frmCarDetails()
        {
            InitializeComponent();
        }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cbManufacturer.SelectedIndex = 0;
            tbID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                tbID.Text = CarInfo.carID.ToString();
                tbName.Text = CarInfo.carName;
                cbManufacturer.SelectedItem = CarInfo.manufacturer;
                mtbYear.Text = CarInfo.manufacturer.ToString();
                mtbPrice.Text = CarInfo.price.ToString();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {   
            try
            {
                var car  = new Car
                {
                    carID = int.Parse(tbID.Text),
                    carName = tbName.Text,
                    manufacturer = cbManufacturer.SelectedItem.ToString(),
                    releaseYear = int.Parse(mtbYear.Text),
                    price = double.Parse(mtbPrice.Text)
                };
                if(InsertOrUpdate)
                {
                    carRepository.updateCar(car);
                } else
                {
                    carRepository.insertCar(car);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "update a car");
            }
        }
    }
}
