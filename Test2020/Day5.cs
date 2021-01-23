using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Year2020.Day5;

namespace Test2020
{
    public class Day5
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Day5(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void FindHighestSeatNumber()
        {
            _testOutputHelper.WriteLine(Challenge.ParseAllSeats().Max(seat => seat.SeatId).ToString());
        }
        
        [Fact]
        public void FindYourSeatNumber()
        {
            _testOutputHelper.WriteLine(Challenge.YourSeatID().ToString());
        }

        [Fact]
        public void EnsureGetRow()
        {
            Assert.Equal(44, Challenge.GetRow("FBFBBFF"));
        }
        
        [Fact]
        public void EnsureParseAllSeats()
        {
            Assert.NotNull(Challenge.ParseAllSeats());
        }

        [Fact]
        public void EnsureGetData()
        {
            Assert.NotNull(Challenge.GetData());
        }
    }
}