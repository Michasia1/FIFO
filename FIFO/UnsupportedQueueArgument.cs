using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO
{
    public class UnsupportedQueueArgument : Exception
    {
        public UnsupportedQueueArgument(int n) : base("Nie mozna dodac do kolejki ujemnych liczb: " + n)
        {

        }
    }
}
