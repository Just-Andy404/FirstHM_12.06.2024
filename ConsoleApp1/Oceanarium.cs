using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Oceanarium : IEnumerable<Creature>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Creature> _creatures;

        public Oceanarium(string name)
        {
            Name = name;
            Address = "NoAddress";
            _creatures = new List<Creature>();
        }

        public Creature this[int index]
        {
            get
            {
                if (index >= 0 && index < _creatures.Count)
                {
                    return _creatures[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
            }
            set
            {
                if (index >= 0 && index < _creatures.Count)
                {
                    _creatures[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
            }
        }

        public void AddCreature(Creature creature)
        {
            if (creature != null)
            {
                _creatures.Add(creature);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Creature creature in _creatures)
            {
                sb.AppendLine(creature.ToString());
            }
            return sb.ToString();
        }

        public IEnumerator<Creature> GetEnumerator()
        {
            return _creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
