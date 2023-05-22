using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public abstract class FootballPlayer:Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
    }
}
