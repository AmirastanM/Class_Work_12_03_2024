﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_HomeTask_12_03_2024
{
    internal class IntList
    {
        public int age { get; set; }
        private int[] intArray;

        public IntList()
        {
            intArray = Array.Empty<int>();
        }

        public void Add(int num)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;
        }

        public int[] GetAll()
        {
            return intArray;
        }
    }
}
