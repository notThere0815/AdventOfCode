using System.Linq;

namespace Year2020.Day5
{
    public class Seat
    {
        private int RowUpperBound { get; set; }
        private int RowLowerBound { get; set; }
        private int ColUpperBound { get; set; }
        private int ColLowerBound { get; set; }
        
        private const char RowUpperChar = 'B';
        private const char RowLowerChar = 'F';
        private const char ColUpperChar = 'R';
        private const char ColLowerChar = 'L';

        public bool IsLimited => RowLowerBound == RowUpperBound && ColLowerBound == ColUpperBound;

        public Seat(int rows, int cols)
        {
            RowUpperBound = rows;
            ColUpperBound = cols;
            RowLowerBound = 0;
            ColLowerBound = 0;
        }

        public bool Limit(string limiters)
        {
            return limiters.Any(Limit);
        }

        public bool Limit(char limiter)
        {
            switch (limiter)
            {
                // limit upper bound and lower bound of rows and cols using the limiter
                case RowUpperChar:
                    RowUpper();
                    break;
                case RowLowerChar:
                    RowLower();
                    break;
                case ColUpperChar:
                    ColUpper();
                    break;
                case ColLowerChar:
                    ColLower();
                    break;
            }
            return IsLimited;
        }

        private void RowUpper()
        {
            
        }
        private void RowLower()
        {
            
        }
        private void ColUpper()
        {
            
        }
        private void ColLower()
        {
            
        }
    }
}