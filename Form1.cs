using LashaMurgvaLominadzeShraieri.Final.Models;
using LashaMurgvaLominadzeShraieri.Final.Services;
using System.ComponentModel;

namespace LashaMurgvaLominadzeShraieri.Final
{
    public partial class Form1 : Form
    {
        private readonly CarService _carService;
        private readonly BindingList<Car> _bindingList;
        private int _currentEditIndex = -1;

        public Form1()
        {
            InitializeComponent();
            _carService = new CarService();
            _bindingList = new BindingList<Car>();
            listBox.DataSource = _bindingList;
            listBox.MouseDoubleClick += EditCar;
        }

        private void addCar(object sender, EventArgs e)
        {
            string model = modelBox.Text;
            string speedText = speedBox.Text;

            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(speedText))
            {
                MessageBox.Show("Model and Speed cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(speedText, out double speed) || speed < 0)
            {
                MessageBox.Show("Speed must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Car car = new Car { Model = model, Speed = speed };
            _carService.AddCar(car);

            modelBox.Clear();
            speedBox.Clear();
            Sync();
        }

        private void deleteCar(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select a car to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _carService.DeleteCar(index);
            Sync();
        }

        private void EditCar(object sender, MouseEventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index == -1)
                return;

            var selected = _carService.GetCars().ToList()[index];
            modelBox.Text = selected.Model;
            speedBox.Text = selected.Speed.ToString();

            _currentEditIndex = index;

            updateBtn.Click -= UpdateCar;
            updateBtn.Click += UpdateCar;
        }

        private void UpdateCar(object? s, EventArgs args)
        {
            if (_currentEditIndex == -1)
                return;

            string model = modelBox.Text;
            string speedText = speedBox.Text;

            if (!double.TryParse(speedText, out double speed) || speed < 0)
            {
                MessageBox.Show("Speed must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Car updated = new Car
            {
                Model = model,
                Speed = speed
            };

            _carService.UpdateCar(_currentEditIndex, updated);
            _currentEditIndex = -1;

            modelBox.Clear();
            speedBox.Clear();
            Sync();

            updateBtn.Click -= UpdateCar;
        }

        private void Sync()
        {
            _bindingList.Clear();
            var cars = _carService.GetCars();

            foreach (var car in cars)
                _bindingList.Add(car);
        }
    }
}
