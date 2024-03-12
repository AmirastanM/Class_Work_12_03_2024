using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_HomeTask_12_03_2024
{
    internal class DataList<T>
    {

        private T[] _datas;
        private static readonly object[] _data;

        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }
                
        public void Delete(T data)
        {
            //int index = Array.IndexOf(_datas, data);

            //if(index >= 0)
            //{
            //    for(int i = index; i < _datas.Length - 1; i++)
            //    {
            //        _datas[i] = _datas[i + 1];
            //    }

            //    Array.Resize(ref _datas, _datas.Length - 1);
            //    return true;
            //}
            //return false;

            var datas = GetAll();
            _datas = datas.Where(m => !m.Equals(data)).ToArray();
        }

        

    }
}
