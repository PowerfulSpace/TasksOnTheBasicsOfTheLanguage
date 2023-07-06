

//Создайте класс AbstractHandler. 
//В теле класса создать методы void Open(), void Create(), void Chenge(),  абстрактный void Save(). 
//Создать производные  классы  XMLHandler, TXTHandler, DOCHandler  от  базового  класса 
//AbstractHandler. 
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  



AbstractHandler format;

format = new XMLHandler();
//format = new TXTHandler();
//format = new DOCHandler();

switch (format)
{
    case XMLHandler:
        Console.WriteLine("Формат является как XMLHandler ");
        break;
    case TXTHandler:
        Console.WriteLine("Формат является как TXTHandler ");
        break;
    case DOCHandler:
        Console.WriteLine("Формат является как DOCHandler ");
        break;
    default:
        break;
}

format.Open();
format.Create();
format.Chenge();
format.Save();

Console.ReadLine();

abstract class AbstractHandler
{
    public void Open()
    {
        Console.WriteLine("Документ открыт");
    }
    public void Create()
    {
        Console.WriteLine("Документ Создан");
    }
    public void Chenge()
    {
        Console.WriteLine("Документ Изменён");
    }
    public abstract void Save();
}

class XMLHandler : AbstractHandler
{
    public override void Save()
    {
        Console.WriteLine("Сохраненно как XML");
    }
}
class TXTHandler : AbstractHandler
{
    public override void Save()
    {
        Console.WriteLine("Сохраненно как TXT");
    }
}
class DOCHandler : AbstractHandler
{
    public override void Save()
    {
        Console.WriteLine("Сохраненно как DOC");
    }
}


