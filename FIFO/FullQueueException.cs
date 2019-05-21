using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO
{
    public class FullQueueException : Exception
    {
        public FullQueueException() : base("Kolejka pełna, nie mozna dodac wiecej liczb!")
        {

        }
    }
}
