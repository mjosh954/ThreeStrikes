using System;
using System.Collections.Generic;

namespace ThreeStrikes.Domain
{
    public sealed class PrizePanel : IEnumerable<Panel>
    {
        private Panel[] panels;

        public PrizePanel(int prizeValue)
        {
            panels = new Panel[5];

            for (int i = 0; i < 5; i++)
            {
                Panel pan = new Panel(Convert.ToInt16(prizeValue.ToString().Substring(i, 1)));
                panels[i] = pan;
            }
        }

        public IEnumerator<Panel> GetEnumerator()
        {
            foreach (Panel p in panels)
            {
                if (p == null)
                    break;
                yield return p;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        internal bool CheckPanel(int p, NumberDisk numberDisk)
        {
            return panels[p].CheckMatch(numberDisk.Value);
        }
    }

    public class Panel
    {
        public bool isVisible { get; set; }
        public int Value;

        public Panel(int val)
        {
            isVisible = false;
            Value = val;
        }

        public bool CheckMatch(int val)
        {
            if (Value == val)
            {
                isVisible = true;
                return true;
            }

            return false;
        }
    }
}
