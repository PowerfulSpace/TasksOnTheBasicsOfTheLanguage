

//Представьте, что вы пишите приложение для Автостанции и вам необходимо создать
//простую коллекцию автомобилей со следующими данными: Марка автомобиля, модель,
//год выпуска, цвет. А также вторую коллекцию с моделью автомобиля, именем покупателя
//и его номером телефона. Используя простейший LINQ запрос, выведите на экран
//информацию о покупателе одного из автомобилей и полную характеристику приобретенной им модели автомобиля.


using System.Drawing;
using System.Reflection;

List<Car> cars = new List<Car>();
cars.Add(new Car("Mersedes", "Maybach", DateTime.Parse("2008-05-01"), "blue"));
cars.Add(new Car("Mersedes", "GLA", DateTime.Parse("2000-06-12"), "yellow"));
cars.Add(new Car("BMW", "X5", DateTime.Parse("2010-10-01"), "black"));


List<Custommer> custommers = new List<Custommer>();
custommers.Add(new Custommer("Maybach", "Саня", "777-77-77"));
custommers.Add(new Custommer("GLA", "Вася", "666-55-34"));
custommers.Add(new Custommer("X6", "Инна", "343-22-54"));
custommers.Add(new Custommer("X5", "Надя", "343-22-54"));
custommers.Add(new Custommer("Maybach", "Ирка", "343-22-54"));
custommers.Add(new Custommer("GLA", "Васяяя", "343-22-54"));


var query = from car in cars
            join custommer in custommers
            on car.Model equals custommer.Model
            select new
            {
                FirstName = custommer.FirstName,
                Marka = car.Marka,
                Model = car.Model,
                DateManufacture = car.DateManufacture,
                Color = car.Color
            };

foreach (var item in query.Where(x => x.FirstName == "Саня"))
{
    Console.WriteLine("{0} {1} {2} {3} {4}",item.FirstName,item.Marka,item.Model,item.DateManufacture,item.Color);
}


Console.ReadLine();

class Custommer
{
    public string Model { get; set; }
    public string FirstName { get; set; }
    public string Phone { get; set; }

    public Custommer(string model, string firstName, string phone)
    {
        Model = model;
        FirstName = firstName;
        Phone = phone;
    }
}

class Car
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public DateTime DateManufacture { get; set; }
    public string Color { get; set; }

    public Car(string marka, string model, DateTime dateManufacture, string color)
    {
        Marka = marka;
        Model = model;
        DateManufacture = dateManufacture;
        Color = color;
    }
}





