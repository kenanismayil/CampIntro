using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntro
{
    class MyDictionary<T, U>
    {
        //Key ve Value dizileri olusturdum.
        //Gecici key ve value dizileri de olusturdum.
        T[] _key;
        U[] _value;
        T[] _tempKey;
        U[] _tempValue;


        public MyDictionary()
        {
            //0 boyutlu key ve value diziler olusturuldu.
            _key = new T[0];
            _value = new U[0];
        }

        public void Add(T key, U value)
        {
            //Key ve Value onceki degerleri gecici dizilere aktarildi.
            _tempKey = _key;
            _tempValue = _value;

            //Her yeni key ve value degerleri eklendikce bellegin heap bolgesinde key ve value alanlari acilacak ve elemanlar icerisine yerlestirilecektir.
            _key = new T[_key.Length + 1];
            _value = new U[_value.Length + 1];

            //Key ve Value'nun onceki degerleri dizilere atanir.
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            //Key ve Value'nun son elemanlari dizilere atanir.
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public T[] Keys
        {
            get { return _key; }
        }

        public U[] Values
        {
            get { return _value; }
        }

        public int Length
        {
            get { return _key.Length; }
        }

        

    }
}
