using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace rep
{ 
    class Node{
        public int data;
        public Node next;
    }
    public class MyLinkedList
    {
         private Node _head ;
         private int count;
         public int Count{
           get{return count;} 
         }
         public void Add(int item)
         {
            Node newNode = new Node();
            newNode.data=item;
            if(_head==null){
                _head =newNode;
                return;
            }
            Node currentNode;
            for(currentNode = _head; currentNode.next != null; currentNode = currentNode.next)
            {

            }
            currentNode.next = newNode;
            count++;
         }
         public void remove(int item){
            if(_head.data == item)
            {
                _head=_head.next;
                return;
            }
             Node currentNode;
            for(currentNode = _head; currentNode.next.data != item; currentNode = currentNode.next)
            {

            }
            currentNode.next= currentNode.next.next;
            count--;
         } 
         public void Print(){
            Node currentNode=_head;
            for(;currentNode != null; currentNode=currentNode.next){
                Console.WriteLine(currentNode.data);
            }
         }
    }
}