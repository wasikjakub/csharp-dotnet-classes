using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees
{
    // CW 1
    public class Tree
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Tree(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Fir : Tree
    {
        protected class Bauble
        {
            public string Color { get; set; }
            public string Type { get; set; }

            public Bauble(string color, string type)
            {
                Color = color;
                Type = type;
            }
        }

        private List<Bauble> Baubles { get; set; } = new List<Bauble>();

        public Fir(string name, int age) : base(name, age)
        {
        }

        public void Add(string color, string type)
        {
            Baubles.Add(new Bauble(color, type));
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < Baubles.Count)
            {
                Baubles.RemoveAt(index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Baubles.Count)
                {
                    return Baubles[index].Color;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid bauble index.");
                }
            }
            set
            {
                if (index >= 0 && index < Baubles.Count)
                {
                    Baubles[index].Color = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid bauble index.");
                }
            }
        }

        public int this[string color]
        {
            get
            {
                return Baubles.Count(b => b.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
            }
        }

        protected List<Bauble> GetBaubles() => Baubles;
    }

    public class ChristmasTree : Fir
    {
        public ChristmasTree(string name, int age) : base(name, age)
        {
        }
    }
    // CW 2
    public class ChristmasTreeA : ChristmasTree
    {
        public ChristmasTreeA(string name, int age) : base(name, age)
        {
        }

        public new string this[int index]
        {
            get
            {
                var baubles = GetBaubles();
                if (index >= 0 && index < baubles.Count)
                {
                    return baubles[index].Type;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid bauble index.");
                }
            }
        }

        public string BaubleColor(int idx)
        {
            return base[idx];
        }
    }
    // CW 3

    public class ChristmasTreeB : ChristmasTreeA
    {
        public ChristmasTreeB(string name, int age) : base(name, age)
        {
        }

        public new string this[int index]
        {
            get
            {
                var baubles = GetBaubles();
                if (index >= 0 && index < baubles.Count)
                {
                    return $"{baubles[index].Color}_{baubles[index].Type}";
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid bauble index.");
                }
            }
        }
    }
    // CW 4 - sealed uniemozliwia dziedziczenie
    public sealed class ChristmasTreeC : ChristmasTreeB
    {
        public ChristmasTreeC(string name, int age) : base(name, age)
        {
        }
    }

    // CW 5

    public abstract class Home
    {
        public abstract int Price(); 

        public int Price(int sqm)
        {
            return sqm * 5000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
