namespace ThreeStrikes.Domain
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
