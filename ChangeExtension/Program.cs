
string path = @"C:\Windows\notepad.exe";
Console.WriteLine(path);

Console.WriteLine("Ext: {0}", Path.GetExtension(path));


Console.WriteLine("Change Path: {0}", path = Path.ChangeExtension(path, "bak"));
Console.WriteLine(path);



Console.ReadLine();