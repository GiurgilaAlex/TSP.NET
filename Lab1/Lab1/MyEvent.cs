using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MyEvent
    {
        public delegate void InfoDelegate(object obj);
        public event InfoDelegate InfoChanged;

        object _object;

        public object SetInfo
        {
            set
            {
                _object = value;
                InfoChanged(_object);
            }
        }
    }
}
