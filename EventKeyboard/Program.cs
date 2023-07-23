




Keyboard keyboard = new Keyboard();

keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
keyboard.PressKeyB += PressKeyB_Handler;

keyboard.Start();




static void PressKeyA_Handler()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine();
    Console.WriteLine("    X    ");
    Console.WriteLine("   X X   ");
    Console.WriteLine("  X   X  ");
    Console.WriteLine(" XXXXXXX ");
    Console.WriteLine("X       X");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
}

static void PressKeyB_Handler()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("XXXXX  ");
    Console.WriteLine("X    X ");
    Console.WriteLine("XXXXXX ");
    Console.WriteLine("X     X");
    Console.WriteLine("XXXXXX ");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
}




public delegate void PressKeyEventHandler();


public class Keyboard
{
    public event PressKeyEventHandler PressKeyA = null;
    public event PressKeyEventHandler PressKeyB = null;
    //  C ... Z

    public void PressKeyAEvent()
    {
        if (PressKeyA != null)
        {
            PressKeyA.Invoke();
        }
    }

    public void PressKeyBEvent()
    {
        if (PressKeyB != null)
        {
            PressKeyB.Invoke();
        }
    }

    public void Start()
    {
        while (true)
        {
            string s = Console.ReadLine();

            switch (s)
            {
                case "a":
                case "A":
                    PressKeyAEvent();
                    break;
                case "b":
                case "B":
                    PressKeyBEvent();
                    break;
                case "exit":
                    goto Exit;

                default:
                    Console.WriteLine("Нет обработчика нажатия на клавишу {0}", s);
                    break;
            }
        }
    Exit:
        Console.WriteLine("Exit!");
    }
}
