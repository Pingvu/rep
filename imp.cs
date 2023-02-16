using rep;
/*MyList list= new MyList();

for (int i = 0; i < 11; i++)
{
    list.add(i);
}
list.RemoveAt(7);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}*/

MyLinkedList linkedlist= new MyLinkedList();
linkedlist.Add(1);
linkedlist.Add(2);
linkedlist.Add(3);
linkedlist.Add(4);
linkedlist.Add(5);
linkedlist.remove(4);

linkedlist.Print();