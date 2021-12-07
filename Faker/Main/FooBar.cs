using System;
using System.Collections.Generic;

namespace Main
{
   public class Bar
    {
        public long longBar;
        public bool booleanInv;
        public int _int;
        private readonly int intBar;
        public long a;
        public DateTime date;
        public int Some { get; set; }
        public long Long { get; set; }

        public Bar(int intBar)
        {
            this.intBar = intBar;
        }

        public int ValueSome { get { return this.intBar; } }
    }

   public class Foo
    {
        public Some he123;
        public int intFoo;
        public List<int> list;
        public float floatFoo;
        public double doubleFoo;
        public long test { get; set; }
    }

   public class Some
    {
        public Bar bar;
    }   
}