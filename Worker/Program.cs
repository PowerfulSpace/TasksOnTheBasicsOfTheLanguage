

//Требуется: Описать структуру с именем Worker, содержащую следующие поля:  
//•  фамилия и инициалы работника;  
//•  название занимаемой должности;  
//•  год поступления на работу.  
//Написать программу, выполняющую следующие действия:  
//•  ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны 
//быть упорядочены по алфавиту);  
//•  если значение года введено не в соответствующем формате выдает исключение. 
//•  вывод на экран фамилии работника, стаж работы которого превышает введенное значение.   



using System.Text.RegularExpressions;


int age = 25;
Worker[] workers = GetWorkers(5);

Worker[] employeesExceedingYears = GetEmployeesExceedingYears(workers, age);

Show(employeesExceedingYears, age);


Console.ReadLine();


static Worker GetEmployee(int indexEmployee)
{
    string patternNameEmployee = @"^[А-Яа-я]{2,15}\s{1}[А-Яа-я].\s{1}[А-Яа-я]{1}.$";
    string patternpositionGehalten = @"^[А-Яа-я]{2,20}$";
    string patternYearOfEmployment = @"^[0-9]{2}.[0-9]{2}.[0-9]{4}$";

    Regex rg;
    Worker worker;



    string nameEmployee;
    rg = new Regex(patternNameEmployee);
    do
    {
        Console.WriteLine($"Введите имя {indexEmployee} и инициалы сотрудника (Имя Инициал. Инициал.) пример (Петров А. А.)");
        nameEmployee = Console.ReadLine();
    } while (!rg.IsMatch(nameEmployee));


    string positionGehalten;
    rg = new Regex(patternpositionGehalten);
    do
    {
        Console.WriteLine($"Введите Должность {indexEmployee} сотрудника (Должность) пример(Разнорабочий)");
        positionGehalten = Console.ReadLine();
    } while (!rg.IsMatch(positionGehalten));


    string yearOfEmploymentString;
    rg = new Regex(patternYearOfEmployment);
    DateTime yearOfEmployment = new DateTime();
    bool flag = false;
    do
    {
        do
        {
            Console.WriteLine($"Введите Год поступления на работу {indexEmployee} сотрудника (день месяц. год.) в цифровом формате пример (10.01.2000)");
            yearOfEmploymentString = Console.ReadLine();
        } while (!rg.IsMatch(yearOfEmploymentString));

        string[] date = yearOfEmploymentString.Split('.');

        try
        {
            yearOfEmployment = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            flag = true;
        }
        catch (ArgumentOutOfRangeException e)
        {
            flag = false;
        }

    } while (!flag);

    worker = new Worker { SurnameAndInitialsOfTheEmployee = nameEmployee, PositionGehalten = positionGehalten, YearOfEmployment = yearOfEmployment };
    Console.WriteLine(new string('-',30));
    return worker;
}

static Worker[] GetEmployeesExceedingYears(Worker[] workers, int years)
{
    List<Worker> employeesExceedingYears = new List<Worker>();
    var year = DateTime.Now.Year;
    employeesExceedingYears = workers.Where(x => year - x.YearOfEmployment.Year > years).ToList();
    return employeesExceedingYears.ToArray();
}


static Worker[] GetWorkers(int count)
{
    Worker[] workers = new Worker[count];

    for (int i = 0; i < count; i++)
    {
        workers[i] = GetEmployee(i+1);
    }

    //workers[0] = new Worker { SurnameAndInitialsOfTheEmployee = "Васькин А Б", PositionGehalten = "Директор", YearOfEmployment = new DateTime(1995, 12, 10) };
    //workers[1] = new Worker { SurnameAndInitialsOfTheEmployee = "Петрушкин Е А", PositionGehalten = "Подстилка", YearOfEmployment = new DateTime(2000, 1, 18) };
    //workers[2] = new Worker { SurnameAndInitialsOfTheEmployee = "Точачьник У Р", PositionGehalten = "Учитель", YearOfEmployment = new DateTime(1990, 3, 1) };
    //workers[3] = new Worker { SurnameAndInitialsOfTheEmployee = "Уткадав Б Н", PositionGehalten = "Физрук", YearOfEmployment = new DateTime(2015, 5, 13) };
    //workers[4] = new Worker { SurnameAndInitialsOfTheEmployee = "Антоновский Е И", PositionGehalten = "Танцор", YearOfEmployment = new DateTime(2000, 12, 5) };

    workers = workers.OrderBy(x => x.SurnameAndInitialsOfTheEmployee).ToArray();

    return workers;
}

static void Show(Worker[] workers, int years)
{
    if (workers.Length > 0)
    {
        Console.WriteLine($"фамилии работника, стаж работы которого превышает {years} лет");
        foreach (var employee in workers)
        {
            Console.WriteLine(employee.SurnameAndInitialsOfTheEmployee);
        }
    }
    else
    {
        Console.WriteLine("Таких сотрудников нет");
    }
}



struct Worker
{
    public string SurnameAndInitialsOfTheEmployee { get; set; }
    public string PositionGehalten { get; set; }
    public DateTime YearOfEmployment { get; set; }
}






