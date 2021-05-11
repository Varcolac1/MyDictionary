using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<K, T>
    {
        K[] array;
        K[] tempArray;
        T[] array2;
        T[] tempArray2;
        public MyDictionary()
        {
            array = new K[0];
            array2 = new T[0];
        }
        public void Add(K key, T type)
        {
            tempArray = array;
            tempArray2 = array2;
            array = new K[array.Length + 1];
            array2 = new T[array2.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                array2[i] = tempArray2[i];
            }

            array[array.Length - 1] = key;
            array2[array2.Length - 1] = type;

        }
        public int Length
        {
            get { return array.Length; }
        }
    }
}
