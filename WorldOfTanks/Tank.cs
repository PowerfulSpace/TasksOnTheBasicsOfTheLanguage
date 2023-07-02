
//Написать приложение WorldOfTanks. Должен состояться танковый бой 5х5,
//т.е. 5 русских танков против 5 немецких. Весь бой должен состоять из пяти дуэльных сражений (один-на-один).
//Победителем боя будет являться танки, которые наберут большее количество очков в пяти сражениях.

//Танк должен быть представлен классом Tank. В нем должны быть определены 4 поля
//(имя танка, боезапас, уровень брони, уровень маневренности).
//Также в классе должен быть перегружен оператор, например умножение, для имитации дуэльного сражения.

//В дуэльном сражении побеждает тот танк, у которого минимум два параметра из трех
//(боезапас, уровень брони, уровень маневренности) больше, чем у противника.
//Общая победа команды зависит от количества очков в дуэльных сражениях.





class Tank
{
    public readonly string Name;
    public readonly int Amunnition;
    public readonly int ArmorLevel;
    public readonly int LevelOfManeuverability;

    public Tank(string name, int amunnition, int armorLevel, int levelOfManeuverability)
    {
        this.Name = name;
        this.Amunnition = amunnition;
        this.ArmorLevel = armorLevel;
        this.LevelOfManeuverability = levelOfManeuverability;
    }

    public static int operator >=(Tank tankA, Tank tankB)
    {
        int a = 0;
        int b = 0;

        a = (tankA.Amunnition > tankB.Amunnition ? 1 : 0) + (tankA.ArmorLevel > tankB.ArmorLevel ? 1 : 0) + (tankA.LevelOfManeuverability > tankB.LevelOfManeuverability ? 1 : 0);
        b = (tankB.Amunnition > tankA.Amunnition ? 1 : 0) + (tankB.ArmorLevel > tankA.ArmorLevel ? 1 : 0) + (tankB.LevelOfManeuverability > tankA.LevelOfManeuverability ? 1 : 0);

        int result = a != b ? a > b ? 1: -1 : 0;

        return result;
    }
    public static int operator <=(Tank tankA, Tank tankB)
    {
        int a = 0;
        int b = 0;

        a += tankA.Amunnition < tankB.Amunnition ? 1 : 0 + tankA.ArmorLevel < tankB.ArmorLevel ? 1 : 0 + tankA.LevelOfManeuverability < tankB.LevelOfManeuverability ? 1 : 0;
        b += tankB.Amunnition < tankA.Amunnition ? 1 : 0 + tankB.ArmorLevel < tankA.ArmorLevel ? 1 : 0 + tankB.LevelOfManeuverability < tankA.LevelOfManeuverability ? 1 : 0;

        int result = a != b ? a > b ? 1 : -1 : 0;

        return result;
    }

    public void Show()
    {
        Console.WriteLine($"Имя: {Name}, Количество снадярдом: {Amunnition}, Броня: {ArmorLevel}, Манёвренность: {LevelOfManeuverability}");
    }
}
