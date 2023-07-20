//Создать свой двусвязный список. В классе узла должны быть  поля: next, prev, value.
//В классе списка должны быть поля: first, last, и методы AddLast, AddAfter.
//Обеспечить возможность перебора элементов списка.

MyLinkedList<int> list = new MyLinkedList<int>();
//list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
//list.AddLast(4);

foreach (var item in list)
{
    Console.Write(item + " ");
}
Console.WriteLine();

list.AddAfter(2,20);
list.AddAfter(3,30);

foreach (var item in list)
{
    Console.Write(item + " ");
}

Console.ReadLine();
