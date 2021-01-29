using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class PersonalMenager<Tkey,Vvalue>
    {
        private List<Tkey> _keys;
        private List<Vvalue> _values;
        List<string> MyList = new List<string>();

        public PersonalMenager()
        {
            _keys = new List<Tkey>();
            _values = new List<Vvalue>();
        }
        public void Add(Tkey T,Vvalue V)
        {
            _keys.Add(T);
            _values.Add(V);
        }
    }
}
