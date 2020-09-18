using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace DelegatesAndLinqEtc
{
    public class NumberGenerator
    {
        public List<int> GetNumbersOneToOneHundredList()
        {
            var result = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                result.Add(i + 1);
            }
            return result;
        }

        public IEnumerable<int> GetNumbersOneToOneHundredIEnumerable()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                yield return i + 1;
            }
        }

        public IEnumerable<string> FavMovies() {
        
            yield return "shadows";
            yield return "faces";
            yield return "ah";
        }
    }
}
