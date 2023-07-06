


//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void 
//Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.  


Player player = new Player();

Console.WriteLine("Проигрывание или записать");
//string statusPlayer = "play";
string statusPlayer = "record";


IPlayable play = player;
IRecodable record = player;

switch (statusPlayer)
{
    case "play":
        play.Play();
        play.Pause();
        play.Stop();
        break;
    default:
        record.Record();
        record.Pause();
        record.Stop();
        break;
}


Console.ReadLine();


static void PlayerStart(string statusPlayer, Player player)
{
    IPlayable play = player;
    IRecodable record = player;

    switch (statusPlayer)
    {
        case "play":
            play.Play();
            play.Pause();
            play.Stop();
            break;
        default:
            record.Record();
            record.Pause();
            record.Stop();
            break;
    }


}

interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}
interface IRecodable
{
    void Record();
    void Pause();
    void Stop();
}

class Player : IPlayable, IRecodable
{
    public void Play()
    {
        Console.WriteLine("Плэер воспроизвёлся");
    }
    public void Record()
    {
        Console.WriteLine("Плэер Поставлен на запись");
    }
    void IPlayable.Pause()
    {
        Console.WriteLine("Плэер поставил воспроизведение на паузу");
    }
    void IPlayable.Stop()
    {
        Console.WriteLine("Плэер остановил воспроизведение");
    }
    void IRecodable.Pause()
    {
        Console.WriteLine("Плэер поставил запись на паузу");
    }
    void IRecodable.Stop()
    {
        Console.WriteLine("Плэер остановил запись");
    }
}
