using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests
{
    public class TestData
    {
        public static object[] PositiveInts =
        {
            new int[][] { new int[] { 1 },                  new int[] { 1 }                 },
            new int[][] { new int[] { 11,2,6 },             new int[] { 2,6,11 }            },
            new int[][] { new int[] { 4,1,2,90,24,100 },    new int[] { 1,2,4,24,90,100 }   },
            new int[][] { new int[] { 99,64,50,81 },        new int[] { 50,64,81,99 }       }
        };

        public static object[] NegativeInts =
        {
            new int[][] { new int[] { -1 },                 new int[] { -1 }                },
            new int[][] { new int[] { -50,-1,-100 },        new int[] { -100,-50,-1 }       },
            new int[][] { new int[] { -2,-34,-17,-9,-3 },   new int[] { -34,-17,-9,-3,-2 }  },
            new int[][] { new int[] { 99,64,50,81 },        new int[] { -54,-41,-26,-10 }   }
        };

        public static object[] PositiveAndNegativeInts =
        {
            new int[][] { new int[] { 300,120,4,-1 },       new int[] { -1,4,120,300 }      },
            new int[][] { new int[] { 0,-99,42,-30,23 },    new int[] { -99,-30,0,23,42 }   },
            new int[][] { new int[] { 36,32,-64,38,37 },    new int[] { -64,32,36,37,38 }   },
            new int[][] { new int[] { 22,45,-12,-8,7 },     new int[] { -12,-8,7,22,45 }    }
        };

        public static object[] ReversedInts =
        {
            new int[][] { new int[] { 300,120,4,-1 },       new int[] { -1,4,120,300 }      },
            new int[][] { new int[] { 42,23,0,-30,-99 },    new int[] { -99,-30,0,23,42 }   },
            new int[][] { new int[] { 38,37,36,32,-64 },    new int[] { -64,32,36,37,38 }   },
            new int[][] { new int[] { 45,22,7,-8,-12 },     new int[] { -12,-8,7,22,45 }    }
        };

        public static object[] SingleLengthArray =
        {
            new int[][] { new int[] { 1 },                  new int[] { 1 }                 },
            new int[][] { new int[] { 2 },                  new int[] { 2 }                 },
            new int[][] { new int[] { 3 },                  new int[] { 3 }                 },
            new int[][] { new int[] { -8 },                 new int[] { -8 }                }
        };

        public static object[] SameInts =
        {
            new int[][] { new int[] { 1 },                  new int[] { 1 }                 },
            new int[][] { new int[] { 2,2 },                new int[] { 2,2 }               },
            new int[][] { new int[] { 3,3,3 },              new int[] { 3,3,3 }             },
            new int[][] { new int[] { 8,8,8,8,8,8,8,8 },    new int[] { 8,8,8,8,8,8,8,8 }   }
        };

        public static object[] ExtremeInts =
        {
            new int[][] { new int[] { int.MaxValue, int.MinValue },
                          new int[] { int.MinValue, int.MaxValue } }
        };
    }
}
