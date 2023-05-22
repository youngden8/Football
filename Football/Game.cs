using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Game
    {
        public Team Team1
        {
            get => Team1;
            set
            {
                if (Team1.Players.Count != 11)
                {
                    throw new ArgumentOutOfRangeException("Invadid count of players");
                }
                Team1 = value;
            }
        }
        public Team Team2 
        {
            get => Team2;
            set
            {
                if (Team2.Players.Count != 11)
                {
                    throw new ArgumentOutOfRangeException("Invadid count of players");
                }
                Team2 = value;
            }
        }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees 
        { 
            get=>AssistantReferees;
            set
            {
                if (AssistantReferees.Count != 2)
                {
                    throw new ArgumentOutOfRangeException("Invadid count of Assistant referees");
                }
                AssistantReferees = value;
            } 
        }
        public List<Goal> Goals { get; set; }
        public string GameResult { get; set; }
        public string Winner { get; set; }
    }
}
