
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется: Описать структуру с именем  Train, содержащую следующие поля:  название пункта 
//назначения, номер поезда, время отправления. 
//Написать программу, выполняющую следующие действия: 
//-ввод с клавиатуры данных в массив, состоящий из не менее двух элементов типа Train
//  (записи должны быть упорядочены по номерам поездов);
//-вывод на экран информации о поезде, номер которого введен с клавиатуры
//  (если таких поездов нет, вывести соответствующее сообщение).  



Train[] trains = EnterTrainData(5);

Console.WriteLine("Введите интересующий вас номер поезда");
int numberTrain = IsDigit();

Train myTrain = trains.FirstOrDefault(x => x.TrainNumber == numberTrain);

if (myTrain.StationName != null)
{
    Console.WriteLine("Номер поезда: {0}", myTrain.TrainNumber);
    Console.WriteLine("Станция отправления: {0}", myTrain.StationName);
    Console.WriteLine("Станция прибытия: {0}", myTrain.PlaceDestination);
    Console.WriteLine("Дата отправления: {0}", myTrain.DeparatureTime);
}
else
{
    Console.WriteLine("К сожалению поезда с таким номером нет");
}

Console.ReadLine();

static Train[] EnterTrainData(int count)
{
    Train[] trains = new Train[count];

    string stationName;
    string placeDestination;
    int trainNumber;
    DateTime deparatureTime;

    var nowDate = DateTime.Now;
    int daysInMonth = DateTime.DaysInMonth(nowDate.Year, nowDate.Month);

    #region MyRelis
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Напишите название станции с которой хотите отправится");
        stationName = Console.ReadLine();
        Console.WriteLine("Напишите название станции на которую хотите прибыть");
        placeDestination = Console.ReadLine();
        Console.WriteLine("Напишите номер поезда");
        trainNumber = IsDigit();
        Console.WriteLine("Напишите дату поездки");

        Console.WriteLine("Год, месяц, день");

        int year = IsDigit();
        int day = IsDigit();
        int month = IsDigit();
        do
        {
            year = IsDigit();

        } while (year < DateTime.Now.Year && year > 2023);
        do
        {
            day = IsDigit();

        } while (day < 0 && day > daysInMonth); // Написать метод, который будет выщитывать количество дней в данном месяце
        do
        {
            month = IsDigit();

        } while (month < 0 && month > 12);


        deparatureTime = new DateTime(year, month, day);

        trains[i] = new Train() { StationName = stationName, PlaceDestination = placeDestination, TrainNumber = trainNumber, DeparatureTime = deparatureTime };
    }
    #endregion


    #region MyDaug
    trains[0] = new Train() { StationName = "1", PlaceDestination = "1", TrainNumber = 10, DeparatureTime = DateTime.Now };
    trains[1] = new Train() { StationName = "2", PlaceDestination = "2", TrainNumber = 2, DeparatureTime = DateTime.Now };
    trains[2] = new Train() { StationName = "3", PlaceDestination = "3", TrainNumber = 8, DeparatureTime = DateTime.Now };
    trains[3] = new Train() { StationName = "4", PlaceDestination = "4", TrainNumber = 12, DeparatureTime = DateTime.Now };
    trains[4] = new Train() { StationName = "5", PlaceDestination = "5", TrainNumber = 1, DeparatureTime = DateTime.Now };
    #endregion


    trains = trains.OrderBy(x => x.TrainNumber).ToArray();

    return trains;
}

static int IsDigit()
{
    int digit;
    bool isDigit = false;
    do
    {
        isDigit = int.TryParse(Console.ReadLine(), out digit);
    } while (!isDigit);
    return digit;
}










struct Train
{
    public string StationName { get; set; }
    public string PlaceDestination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DeparatureTime { get; set; }
}

