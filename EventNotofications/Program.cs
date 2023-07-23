

Consumer consumer1 = new Consumer("Вася");
Consumer consumer2 = new Consumer("Петя");
Consumer consumer3 = new Consumer("Вика");
Consumer consumer4 = new Consumer("Даша");
Consumer consumer5 = new Consumer("Надя");

JournalDealer journalInformation = new JournalDealer();


journalInformation.NotifyNewJurnalInfo += consumer1.NewJournal;
journalInformation.NotifyNewJurnalInfo += consumer2.NewJournal;
journalInformation.NotifyNewJurnalInfo += consumer3.NewJournal;
journalInformation.NotifyNewJurnalInfo += consumer4.NewJournal;
journalInformation.NotifyNewJurnalInfo += consumer5.NewJournal;
journalInformation.NewJurnal("Газета Пупсик");

Console.WriteLine();
journalInformation.NotifyNewJurnalInfo -= consumer3.NewJournal;
journalInformation.NotifyNewJurnalInfo -= consumer4.NewJournal;
journalInformation.NewJurnal("Газета учумелые ручки");

Console.ReadLine();



class Consumer
{
    public string Name { get; private set; }
	public Consumer(string name)
	{
        Name = name;
    }

    public void NewJournal(object sender, JournalInfoEventArgs arg)
    {
        Console.WriteLine($"{Name} - Появился новый журнал : {arg.Jurnal}");
    }
}

class JournalInfoEventArgs : EventArgs
{
    public string Jurnal { get; private set; }
    public JournalInfoEventArgs(string jurnal)
    {
        Jurnal = jurnal;
    }
}

class JournalDealer
{
    public event EventHandler<JournalInfoEventArgs> NotifyNewJurnalInfo;

    public void NewJurnal(string name)
    {
        if (NotifyNewJurnalInfo != null)
        {
            Console.WriteLine($"У нас в редакции - Появился новый журнал : {name}");
            NotifyNewJurnalInfo.Invoke(this, new JournalInfoEventArgs(name));
        }
    }
}


