using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace rep
{
    public class MyList
    {
        private int[] data;
        private int count;
        public int Count{
            get{return count;}
        }
        public int this[int i]{
            get{return data[i];}
            set{data[i]=value;
            }
        }
        public MyList(){
            data = new int[10];
        }
        public void add(int item){
            if(count==data.Length)
                { Resize();}
            data[count]=item;
            count++;
        }
        private void Resize(){
            int[] temp =data;
            data = new int[count*2];
            for (int i = 0; i < count; i++)
            {
                data[i]=temp[i];
            }
        }
        public void RemoveAt(int index){
            for (int i = index ; i < count-1; i++)            {
                data[i]= data [i+1];
            }
            count--;
        }
    }
}