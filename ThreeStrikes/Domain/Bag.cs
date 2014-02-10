using System;
using System.Collections;
using System.Collections.Generic;

namespace ThreeStrikes.Domain
{
    public sealed class Bag : ICollection<Disk>
    {
        private List<Disk> Disks { get; set; }

        public Bag(int prize)
        {
            Disks = new List<Disk>();

            string prizeValue = prize.ToString();
            foreach (char c in prizeValue)
            {
                Disk disk = new NumberDisk(Convert.ToInt32(c.ToString()));
                Disks.Add(disk);
            }
            for(int i = 0; i <= 2; i++)
                Disks.Add(new Strike());
        }


        public IEnumerator<Disk> GetEnumerator()
        {
            foreach (var d in Disks)
            {
                if (d == null)
                    break;
                yield return d;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Disk item)
        {
            Disks.Add(item);
        }

        public void Clear()
        {
            Disks.Clear();
        }

        public bool Contains(Disk item)
        {
            return Disks.Contains(item);
        }

        public void CopyTo(Disk[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Disk item)
        {
            return Disks.Remove(item);
        }

        public int Count
        {
            get
            {
                return Disks.Count;
            }
        }

        public bool IsReadOnly { get; private set; }

        public void Shuffle()
        {
            int n = Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Disk value = Disks[k];
                Disks[k] = Disks[n];
                Disks[n] = value;
            }
        }

    }
}
