using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players
        {
            get => Players;
            set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of players");
                }
                Players = value;
            }
        }
        public double AverageAge
        {
            get
            {
                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }
                return totalAge / (double)Players.Count;
            }
        }
    }
}
