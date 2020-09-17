using System;
using System.Collections.Generic;

namespace DelegatesAndLinqEtc
{
    // public delegate bool FilterMethod(int num);

    public class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            // return Filter(numbers, IsOdd);
            // return Filter(numbers, delegate (int x) { return x % 2 != 0; });
            return Filter(numbers, x => x % 2 != 0);
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {
            // return Filter(numbers, IsEven);
            // return Filter(numbers, delegate (int x) { return x % 2 == 0; });
            return Filter(numbers, x => x % 2 == 0);
        }

        // private List<int> Filter(List<int> numbers, FilterMethod m)
        private List<int> Filter(List<int> numbers, Predicate<int> m)
        {
            var results = new List<int>();
            foreach (var num in numbers)
            {
                if (m(num)) results.Add(num);
            }
            return results;
        }

        //private bool IsOdd(int num)
        //{
        //    return num % 2 != 0;
        //}

        //private bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
    }
}