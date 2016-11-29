//*********************************************************
//
// Garvan Gallagher 
// Technical test for Renaissance Reinsurance 
//
//*********************************************************

namespace RenRe.Puzzles.DealLosses
{
    public class Data
    {
        public static int[][] Events
        {
            get
            {
                return new[]
					{
						new []{1, 2, 1, 1000},
						new []{2, 3, 2, 500},
						new []{3, 3, 3, 750},
						new []{4, 1, 3, 2000}
					};
            }
        }
    }
}
