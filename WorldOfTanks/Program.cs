
//Написать приложение WorldOfTanks. Должен состояться танковый бой 5х5,
//т.е. 5 русских танков против 5 немецких. Весь бой должен состоять из пяти дуэльных сражений (один-на-один).
//Победителем боя будет являться танки, которые наберут большее количество очков в пяти сражениях.

//Танк должен быть представлен классом Tank. В нем должны быть определены 4 поля
//(имя танка, боезапас, уровень брони, уровень маневренности).
//Также в классе должен быть перегружен оператор, например умножение, для имитации дуэльного сражения.

//В дуэльном сражении побеждает тот танк, у которого минимум два параметра из трех
//(боезапас, уровень брони, уровень маневренности) больше, чем у противника.
//Общая победа команды зависит от количества очков в дуэльных сражениях.


TankBattle();
Console.ReadLine();

static void TankBattle()
{
    Tank[] cccrTanks = CreationOfTanks("T-34",5);
    Tank[] germanTanks = CreationOfTanks("Pantera", 5);
    int[] points = new int[cccrTanks.Length];

    int cccrTeamPoints = 0;
    int germanTeamPoints = 0;

    string victory;

    for (int i = 0; i < 5; i++)
    {
        int result = cccrTanks[i] >= germanTanks[i];
        switch (result)
        {
            case 1:
                cccrTeamPoints++;
                points[i] = 1;
                break;
            case -1:
                germanTeamPoints++;
                points[i] = -1;
                break;
            default:
                break;
        }
    }
    victory = cccrTeamPoints == germanTeamPoints ? "Ничья" : cccrTeamPoints > germanTeamPoints ? "Победа T-34" : "Победа Pantera";

    Rendering(cccrTanks, germanTanks, points, victory);

}


static Tank[] CreationOfTanks(string name,int count)
{
    Tank[] tanks = new Tank[count];
    Random random= new Random();

    int amunnition;
    int armorLevel;
    int levelOfManeuverability;

    for (int i = 0; i < tanks.Length; i++)
    {
        amunnition = random.Next(10);
        armorLevel = random.Next(10);
        levelOfManeuverability = random.Next(10);

        tanks[i] = new Tank(name, amunnition, armorLevel, levelOfManeuverability);
    }
    return tanks;
}

static void Rendering(Tank[] tankA, Tank[] tankB, int[] tankPoints, string victory)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("{0,-10} {1,15} {2,15} {3,15}", "Состав", "Боекомплект", "Уровень брони", "манёвринность");
    Console.WriteLine(new string('-', 56));

    for (int i = 0; i < 5; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Бой {i + 1} " + new string('-', 50));
        Console.WriteLine("{0,-10} {1,10} {2,15} {3,15}", tankA[i].Name,tankA[i].Amunnition, tankA[i].ArmorLevel, tankA[i].LevelOfManeuverability);
        Console.WriteLine("{0,-10} {1,10} {2,15} {3,15}", tankB[i].Name, tankB[i].Amunnition, tankB[i].ArmorLevel, tankB[i].LevelOfManeuverability);
    }
    Console.WriteLine(new string('-', 56));

    for (int i = 0; i < 5; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Бой {0} {1,5} VS {2,5}",i + 1, tankA[i].Name, tankB[i].Name);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("   {0,-20}", tankPoints[i] != 0 ? tankPoints[i] == 1 ? "Победа " + tankA[i].Name : "Победа " + tankB[i].Name : "Ничья");
    }

    Console.WriteLine(new string('-', 56));
    Console.WriteLine(victory);
}
