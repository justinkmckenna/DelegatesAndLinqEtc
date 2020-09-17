using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public class BuiltInDelegateTypes
    {
        [Fact]
        public void UsingActions()
        {
            // actions - methods that return void, takes 0-16 args
            Action action;
            action = () => Console.Write("ahh");
            action();

            Action<string, int> action2 = (message, times) =>
             {
                 for (int t = 0; t < times; t++)
                 {
                     Console.WriteLine(message);
                 }
             };
            action2("ah",13);
        }

        [Fact]
        public void Funcs()
        {
            // funcs - return something, takes 0-16 args
            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(4, mathOp(2, 2));

            mathOp = (a, b) => a * b;
            Assert.Equal(9, mathOp(3, 3));

            Func<int, bool> even = x => x % 2 == 0;
            Assert.True(even(4));
            Assert.False(even(5));

            var calculator = new Dictionary<char, Func<int, int, int>>
            {
                {'+', (a,b) => a + b },
                {'-', (a,b) => a - b },
                {'*', (a,b) => a * b },
                {'/', (a,b) => a / b }
            };
            var result = calculator['+'](2, 5);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Predicates()
        {
            Predicate<string> doYouLike;
            doYouLike = x => x == "pizza";
            Assert.True(doYouLike("pizza"));
            Assert.False(doYouLike("pizzaaaaa"));
        }
    }
}
