using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortServices.Helpers
{
    public class RandomNumberGeneratorHelper
    {

        private int[] _Dataset { get; set; }
        private Random _Random { get; set; }

        public RandomNumberGeneratorHelper(int _ArraySize = 100)
        {
            if (_ArraySize <= 0)
            {
                throw new ArgumentException("Array size must be a positive integer.");
            }

            _Dataset = new int[_ArraySize];

            _Random = new Random();
        }

        public int[] Generate()
        {

            for (int i = 0; i < _Dataset.Length; i++)
            {
                _Dataset[i] = _Random.Next(1, 10000); // Generating random numbers between 1 and 10000
            }

            return _Dataset;
        }
    }
}
