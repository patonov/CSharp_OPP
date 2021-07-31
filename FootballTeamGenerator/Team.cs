using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowIfNameIsNullOrWhiteSpace(value, "A name should not be empty.");
                this.name = value;
            }
        }

        public double TeamRating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            return Math.Round(this.players.Values.Average(p => p.AverageSkillPoints));
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(playerName);
        }

    }
}
