using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryApp
{
   
    class MyDictionary<TKey,TValue>
    {
        TKey[] Keys;
        TValue[] Values;
        //Constructor...
        public MyDictionary()
    {
          Keys = new TKey[0];
           Values = new TValue[0];
    //Default olarak oluşturması için constructor a yazdım bunu . 
    }

      public void AddItem(TKey Key,TValue Value)
        {
            TKey[] TempKey = Keys;
            TValue[] TempValue = Values;
//Ekleme yapmadan önce ilk dizileri kayıt edecek bir yapı oluşturuldu.
            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];
//Yeni eklenecek olan değerler için uzunluğu şuanki dizinin bir fazlası olan 2 adet yeni dizi oluşturuldu.
         for(int i = 0; i < TempKey.Length;i++)
            {

                Keys[i] = TempKey[i];
                //Yeni keys dizisine eski dizinin elemanları ekleniyor...
                Values[i] = TempValue[i];


            }
            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
            //Yeni Değerler eklendi.
            Console.WriteLine("Değerler eklendi yeni eklenen değerler : Key : {0} , Value : {1} ",Key , Value);
        }

        public int Length
        {
            get { return Keys.Length; }
        
        }
        public  TKey[] ListKeys
        {
            get { return Keys; }
        }

        public  TValue[] ListValues
        {
            get { return Values; }
        }
    }
}
//İlk başta salak gibi tempKey yerine Key yaptım , Key.length tabi 1 olduğu için hata olarak index out of bounds exception aldım ...
//Array programının aynısı gibi , burada mantığını anladıktan sonra çok kolay ilerleniyor. 