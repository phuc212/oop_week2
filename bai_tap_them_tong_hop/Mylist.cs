using System;
using System.Collections;
using System.Collections.Generic;
namespace bai_tap_them_tong_hop
{
    public class Mylist<T>
    {
        public T[] list;
        public int Count => list.Length;
        public Mylist()
        {
            list = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize( ref list, Count +1);
            list[Count - 1] = item;
        }
        public int IndexOf(T seachitem)
        {
           for (int i = 0; i < Count; i++)
           {
               if(list[i].Equals(seachitem))
               {
                   return i;
               }
           }
            return -1;
        }
        public bool Remove(T item)
        {
            if(IndexOf(item) != -1 )
            {
                for (int i = IndexOf(item) ; i < Count -1; i++)
                {
                    list[i] = list[i+1];
                }
                Array.Resize(ref list, Count -1);
                
                return true;
            }else
            return false;

        }

    }
}