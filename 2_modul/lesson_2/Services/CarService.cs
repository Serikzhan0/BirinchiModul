using lesson_2.Models;

namespace lesson_2.Services;

public class CarService
{
    public List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public Car GetById(Guid carId)
    {
        Car car = null;

        foreach (var c in Cars)
        {
            if (c.CarId == carId)
            {
                car = c;
                break;
            }
        }

        return car;
    }

    public bool DeleteCar(Guid carId)
    {
        foreach (var car in Cars)
        {
            if (car.CarId == carId)
            {
                Cars.Remove(car);
                return true;
            }
        }
        return false;
    }

    public void UpdateCar(Car updatedCar)
    {
        Car existingCar = null;

        foreach (var car in Cars)
        {
            if (car.CarId == updatedCar.CarId)
            {
                existingCar = car;
                break;
            }
        }

        if (existingCar != null)
        {
            existingCar.Brand = updatedCar.Brand;
            existingCar.Model = updatedCar.Model;
            existingCar.Year = updatedCar.Year;
            existingCar.Color = updatedCar.Color;
            existingCar.Price = updatedCar.Price;
        }
    }
}