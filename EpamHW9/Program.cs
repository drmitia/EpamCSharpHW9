using System;

namespace EpamHW9
{
    internal class Program
    {
        /*
         - Напишіть клас Automobile (Автомобіль) з полями «Назва» та «Максимальна швидкість» автомобіля. Додайте до класу необхідні методи, конструктори та властивості.
        Зробити колекцію об'єктів типу Automobile (типізований список List). Додати до колекції кілька різних об'єктів типу Automobile. 
        Вивести на екран інформацію про усі автомобілі в колекції. Вивести на екран назву автомобіля, який має найвищу максимальну швидкість.
         */
        static void Main(string[] args)
        {
            List<Automobile> cars = new List<Automobile>();
            cars.Add(new Automobile("Toyota", 150));
            cars.Add(new Automobile("BMW", 200));
            cars.Add(new Automobile("Skoda", 100));
            /*Automobile fastestCar = cars[0];
            foreach (Automobile car in cars)
            {
                Console.WriteLine($"Машина {car.Name} має швидкiсть {car.MaxSpeed}");
                if (car.MaxSpeed >= fastestCar.MaxSpeed)
                {
                    fastestCar = car;
                }              
            }
            Console.WriteLine("Найшвидша машина " + fastestCar.Name + " зi швидкiстю " + fastestCar.MaxSpeed);*/
            foreach (Automobile car in cars)
            {
                Console.WriteLine($"Машина {car.Name} має швидкiсть {car.MaxSpeed}");
            }
            static Automobile FindFastestcar(List<Automobile> array) 
            {
                Automobile max = array[0];
                foreach (Automobile car in array)
                {
                    if (car.MaxSpeed >= max.MaxSpeed)
                    {
                        max = car;
                    }
                }
                return max;
            }
            Automobile a = FindFastestcar(cars);
            Console.WriteLine("Найшвидша машина " + a.Name + " зi швидкiстю " + a.MaxSpeed);
        }
    }
}