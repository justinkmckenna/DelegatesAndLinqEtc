using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public static class Utils
    {
        public static bool isEven(this int x)
        {
            return x % 2 == 0;
        }
    }
    public class ExtensionMethods
    {
        [Fact]
        public void TheCase()
        {
            Assert.True(2.isEven());

            var friends = new List<string> { "me", "ah", "wow" };
            var twoLetteredNames = friends.Where(x => x.Length == 2);
            friends.Add("eh");
            Assert.Equal(3, twoLetteredNames.Count()); // this is really cool
                                                       // waits until this line to actually look at twoLetteredNames data

            var david = friends.SingleOrDefault(x => x == "david");
            Assert.Null(david);
        }

        [Fact]
        public void test()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(Utils.isEven); // evens doesn't contain data yet
            var evensList = numbers.Where(Utils.isEven).ToList(); // data in this because its a list

            // Assert.Equal(2, evens[1]); // can't do this because its an ienumerable, doesn't have data yets, not indexable
            Assert.Equal(2, evensList[0]);

            var five = numbers.SingleOrDefault(n => n == 15);
            Assert.Equal(0, five);
        }
    }
}
