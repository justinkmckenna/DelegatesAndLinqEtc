using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DelegatesAndLinqEtc
{
    public class Enumerables
    {
        ITestOutputHelper _output;

        public Enumerables(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void EnumberablesAreThingsThatYouCanEnumerate()
        {
            var names = new List<string> { "justin", "sean", "hunter" };
            foreach(var name in names)
            {
                _output.WriteLine(name);
            }
            var message = "gummmmmm";
            foreach(var letter in message)
            {
                _output.WriteLine(letter.ToString());
            }
        }

        [Fact]
        public void GettingTheNumbersList()
        {
            var ng = new NumberGenerator();
            var sw = new Stopwatch();
            sw.Start();
            // This will take 10 seconds
            foreach(var n in ng.GetNumbersOneToOneHundredList())
            {
                if (n == 10) break;
            }
            sw.Stop();
            _output.WriteLine($"That took {sw.ElapsedMilliseconds}ms");
        }

        [Fact]
        public void GettingTheNumbersIEnumberable()
        {
            var ng = new NumberGenerator();
            var sw = new Stopwatch();
            sw.Start();
            // This will take 10 seconds
            foreach (var n in ng.GetNumbersOneToOneHundredIEnumerable())
            {
                if (n == 10) break;
            }
            sw.Stop();
            _output.WriteLine($"That took {sw.ElapsedMilliseconds}ms");
        }

        [Fact]
        public void EnumerateMovies()
        {
            var ng = new NumberGenerator();
            foreach (var movie in ng.FavMovies()) _output.WriteLine(movie);
        }
    }
}
