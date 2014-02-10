namespace ThreeStrikes.Domain
{
    public sealed class Prize
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public Prize(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
