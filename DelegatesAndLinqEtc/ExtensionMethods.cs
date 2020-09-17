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
        }
    }
}
