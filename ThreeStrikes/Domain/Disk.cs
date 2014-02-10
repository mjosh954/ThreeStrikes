using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeStrikes
{
    public abstract class Disk
    {
    }

    public class NumberDisk : Disk
    {
        public int Value { get; private set; }

        public NumberDisk(int value)
        {
            Value = value;
        }
    }

    public class Strike : Disk
    {
        
    }
}
