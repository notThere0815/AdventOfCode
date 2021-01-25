using System.Collections.Generic;
using Xunit;
using Year2020.Day6;

namespace Test2020
{
    public class Day6
    {
        [Fact]
        public void EnsureInput()
        {
            Assert.NotEmpty(Challenge.GetData());
        }

        [Fact]
        public void EnsureForm()
        {
            var form = new Form();
            Assert.Equal(0, form.CheckCount);
            form.Check("abcx");
            Assert.Equal(4, form.CheckCount);
            form.Check("abcy");
            Assert.Equal(5, form.CheckCount);
            form.Check("abcz");
            Assert.Equal(6, form.CheckCount);
            form.Check("1ASH");
            Assert.Equal(6, form.CheckCount);
        }
    }
}