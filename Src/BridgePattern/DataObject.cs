using System;
using System.Collections.Generic;

namespace BridgePattern
{
    public interface IDataObject
    {
        void Add(string str);
        void Delete(string str);
        void Current();
        void Next();
        void Prev();
        void ShowAll();
    }
    public class DataObject : IDataObject
    {
        private readonly List<string> _data;
        private int _current;
        public DataObject()
        {
            _data = new List<string>();
            _current = 0;

        }
        public void Add(string str)
        {
            this._data.Add(str);
        }

        public void Delete(string str)
        {
            this._data.Remove(str);
        }

        public void Current()
        {
            Console.WriteLine($"{_data[_current]}");
        }

        public void Next()
        {
            ++_current;
            if (_current >= _data.Count)
            {
                _current = 0;
            }

        }

        public void Prev()
        {
            --_current;
            if (_current < 0)
            {
                _current = 0;
            }
        }

        public void ShowAll()
        {
            foreach (var data in _data)
            {
                Console.WriteLine($"{data}");
            }
        }
    }
}