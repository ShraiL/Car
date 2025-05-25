using LashaMurgvaLominadzeShraieri.Final.Models;

namespace LashaMurgvaLominadzeShraieri.Final.Services
{
    public class CarService
    {
        private readonly List<Car> _cars;

        public CarService()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void DeleteCar(int index)
        {
            if (index >= 0 && index < _cars.Count)
            {
                _cars.RemoveAt(index);
            }
        }

        public void UpdateCar(int index, Car updatedCar)
        {
            if (index >= 0 && index < _cars.Count)
            {
                _cars[index] = updatedCar;
            }
        }

        public IEnumerable<Car> GetCars()
        {
            return _cars;
        }
    }
}
