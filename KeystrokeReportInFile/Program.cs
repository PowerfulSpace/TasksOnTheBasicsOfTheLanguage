
//Создайте проект, который основан на событийной модели (использовать события).
//Его задача состоит в том, чтобы составить отчет (txt-файл) о нажатых клавишах
//за время работы с приложением. Файл должен быть создан в новой директории MySpyDirectory.
//Файл назвать SpyFile. По шаблону: 
//время нажатия клавиши    |   нажатая клавиша    |    
//время нажатия клавиши    |   нажатая клавиша    |    
//время нажатия клавиши    |   нажатая клавиша    |    
//--------------------------------------------------------------------------         
//Всего было нажато клавиш: .......
//Например:
//12:34:23 | Клавиша  'A' |
//12:34: 24 | Клавиша  'B' |
//12:34: 25 | Клавиша  'C' |
//--------------------------------------------------------------------------
//Всего было нажато клавиш: 3


// Это задание сделал. Как для каждого введённого символа, так и для целой строки


Spy spy = new Spy();
spy.NotifySpy += SaveText;
spy.NotifySpyChars += SaveChars;

spy.Working = true;

//spy.Start();
//spy.StartChars();



Console.ReadLine();


static void SaveText(object sender, SpyEventArg arg)
{
    StreamWriter writer = new StreamWriter(@"D:\Testing\MySpyDirectory\SpyFile.txt",true);
    writer.WriteLine(DateTime.Now.ToLongTimeString() + " | " + arg.Text);
    writer.Close();
}

static void SaveChars(object sender, SpyCharEventArg arg)
{
    StreamWriter writer = new StreamWriter(@"D:\Testing\MySpyDirectory\SpyCharsFile.txt", true);
    writer.WriteLine(DateTime.Now.ToLongTimeString() + " | Клавиша " + arg.Char);
    writer.Close();
}

class Spy
{
    public bool Working = false;
    public event EventHandler<SpyEventArg> NotifySpy;
    public event EventHandler<SpyCharEventArg> NotifySpyChars;

    public void Start()
    {
        if (NotifySpy != null)
        {
            while (Working)
            {
                string text = string.Empty;

                text = Console.ReadLine();

                NotifySpy(this, new SpyEventArg(text));
            }
        }
    }
    public void StartChars()
    {
        if (NotifySpyChars != null)
        {
            while (Working)
            {
                char text = char.MinValue;

                text = Console.ReadKey().KeyChar;

                NotifySpyChars(this, new SpyCharEventArg(text));
            }
        }
    }
}

class SpyEventArg : EventArgs
{
    public string Text { get; private set; }
    public SpyEventArg(string text)
    {
        this.Text = text;
    }
}

class SpyCharEventArg : EventArgs
{
    public char Char { get; private set; }
    public SpyCharEventArg(char Char)
    {
        this.Char = Char;
    }
}

