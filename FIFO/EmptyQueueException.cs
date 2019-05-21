using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() : base("Kolejka pusta, nie mozna nic z niej sciagnac!")
        {

        }
    }
}
