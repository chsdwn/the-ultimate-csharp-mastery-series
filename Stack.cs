using System;

namespace ultimate_csharp_mastery
{
    public class Stack
    {
        private object[] _list;

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            if (_list == null)
                _list = new object[] { obj };
            else
            {
                var extendedList = new object[_list.Length + 1];

                for (int i = 0; i < _list.Length; i++)
                    extendedList[i] = _list[i];

                extendedList[_list.Length] = obj;
                _list = extendedList;
            }

        }

        public object Pop()
        {
            var popedValue = _list[_list.Length - 1];

            var reducedList = new object[_list.Length - 1];

            for (int i = 0; i < reducedList.Length; i++)
                reducedList[i] = _list[i];

            _list = reducedList;

            return popedValue;
        }

        public void Clear()
        {
            _list = null;
        }
    }
}