using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathTestGenerator.Data
{
    public class Question
    {
        public int[] NumbersToUse { get; set; } = new int[2];
        public Operations Operation { get; set; }
        public int Result { get; set; }
    }

    public enum Operations
    {
        ADDITION = 0,
        EXTRACTION = 1,
        MULTIPLICATION = 2,
        DIVISION = 3
    }
}
