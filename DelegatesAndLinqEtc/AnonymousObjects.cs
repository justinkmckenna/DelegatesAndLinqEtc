using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public class AnonymousObjects
    {
        [Fact]
        public void UsingThem()
        {
            var movie = new { Title = "jaws", Director = "myself", year=1999 };
            Assert.Equal("jaws", movie.Title);

            var manager = GetManager();
            // no properties, kind of limited

            var numbers = new List<int> { 1, 2, 3 };
            var numbersDoubledAndTurnedIntoStrings = numbers.Select(n=>(n*2).ToString()).ToList();

            Assert.Equal("2", numbersDoubledAndTurnedIntoStrings[0]);
        }

        private object GetManager()
        {
            return new { Name = "karen", Phone = "555-555-5555" };
        }
    }
}
