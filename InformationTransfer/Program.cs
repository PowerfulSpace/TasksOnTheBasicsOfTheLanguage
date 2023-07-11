


//Цель: произвести расчет необходимого количества внешних носителей информации
//при переносе за один раз важной информации (565 Гб, файлы по 780 Мб)
//с рабочего компьютера на домашний компьютер и затрачиваемое на данный процесс время.
//Вы имеете в распоряжении следующие типы носителей информации: 
//• Flash - память, 
//• DVD - диск, 
//• съемный HDD.

//Каждый носитель информации является объектом соответствующего класса:
//- Flash - память - класс «Flash»;
//-класс DVD – диск - класс «DVD»;
//-класс съемный HDD - класс «HDD».

//Все три класса являются производными от абстрактного класса «Носитель информации» - класс «Storage». 
//Базовый класс («Storage») содержит следующие закрытые поля:
//• наименование носителя
//• модель 
//Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами: 
//• получение объема памяти;
//• копирование данных(файлов/папок) на устройство,
//• получение информации о свободном объеме памяти на устройстве;
//• получение общей/полной информации об устройстве. 
//Кроме того, каждый из производных классов дополняется следующими полями:
//-класс Flash - память: скорость USB 3.0, объем памяти;
//-класс DVD - диск: скорость чтения / записи, тип (односторонний(4.7 Гб) / двусторонний(9 Гб));
//-класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.
//Работа с объектами соответствующих классов производится через ссылки на базовый класс («Storage»), которые хранятся в массиве.
//Приложение должно предоставлять следующие возможности:
//• расчет общего количества памяти всех устройств;
//• копирование информации на устройства;
//• расчет времени необходимого для копирования;
//• расчет необходимого количества носителей информации представленных типов для переноса информации.
//Емкость носителей информации должна быть указана в Гб, скорость копирования в Кб.


Storage memoryFlash = new Flash() { MediaName = "Flash", Model = "xiaomi", MemoryCapacity = 16, Speed = 5 };
Storage memoryDVD = new DVD() { MediaName = "DVD", Model = "xiaomi", ReadingSpeed = 10, TypeDVD = "Оптический"};
Storage memoryHDD = new HDD() { MediaName = "HDD", Model = "xiaomi", Speed = 8,NumberOfSections = 4,VolumeOfPartitions= 10 };

Storage[] storages = new Storage[] { memoryFlash, memoryDVD, memoryHDD };


static void CalculationOfTheTotalAmountOfMemoryOfAllDevices()
{
}
static void CopyingInformationToDevices()
{
}
static void CalculationOfTheTimeRequiredForCopying()
{
}
static void CalculationOfTheRequiredNumberOfInformationCarriersOfThePresentedTypesForInformationTransfer()
{
}


abstract class Storage
{
    public string MediaName { get; set; }
    public string Model { get; set; }

    public abstract void GettingTheAmountOfMemory();
    public abstract void CoppingDataToTheDevice();
    public abstract void GettingInformationAboutTheFreeMemoryOnTheDvice();
    public abstract void GettingfullInformationAboutTheDvice();
}
class Flash : Storage
{
    public double Speed { get; set; }
    public double MemoryCapacity { get; set; }

    public override void CoppingDataToTheDevice()
    {
        throw new NotImplementedException();
    }

    public override void GettingfullInformationAboutTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingInformationAboutTheFreeMemoryOnTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingTheAmountOfMemory()
    {
        throw new NotImplementedException();
    }
}
class DVD : Storage
{
    public double ReadingSpeed { get; set; }
    public string TypeDVD { get; set; }

    public override void CoppingDataToTheDevice()
    {
        throw new NotImplementedException();
    }

    public override void GettingfullInformationAboutTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingInformationAboutTheFreeMemoryOnTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingTheAmountOfMemory()
    {
        throw new NotImplementedException();
    }

}
class HDD : Storage
{
    public double Speed { get; set; }
    public int NumberOfSections { get; set; }
    public int VolumeOfPartitions { get; set; }

    public override void CoppingDataToTheDevice()
    {
        throw new NotImplementedException();
    }

    public override void GettingfullInformationAboutTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingInformationAboutTheFreeMemoryOnTheDvice()
    {
        throw new NotImplementedException();
    }

    public override void GettingTheAmountOfMemory()
    {
        throw new NotImplementedException();
    }
}








