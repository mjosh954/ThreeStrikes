using System.Linq;

namespace ThreeStrikes.Domain
{
    public sealed class Player
    {
        public string Name { get; set; }

        public NumberDisk OnHand { get; set; }
        
        public Player(string name)
        {
            Name = name;
        }

        public Disk PickOne(Bag bag)
        {
            Disk d = bag.First();
            bag.Remove(d);
            
            return d;
        }
    }
}
