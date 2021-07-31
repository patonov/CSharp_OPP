using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var parts = line.Split(';');

                var command = parts[0];

                try
                {
                    if (command == "Add")
                    {
                        var teamName = parts[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        var playerName = parts[2];
                        int endurance = int.Parse(parts[3]);
                        int sprint = int.Parse(parts[4]);
                        int dribble = int.Parse(parts[5]);
                        int passing = int.Parse(parts[6]);
                        int shooting = int.Parse(parts[7]);

                        var team = teams[teamName];

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        team.AddPlayer(player);

                    }
                    else if (command == "Remove")
                    {
                        var teamName = parts[1];
                        var playerName = parts[2];

                        var team = teams[teamName];

                        team.RemovePlayer(playerName);

                    }
                    else if (command == "Rating")
                    {
                        var teamName = parts[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                        var team = teams[teamName];

                        var averageRating = team.TeamRating();

                        Console.WriteLine($"Team {teamName} - {averageRating}");
                    }
                    else if (command == "Team")
                    {
                        var teamName = parts[1];

                        Team team = new Team(teamName);

                        teams.Add(teamName, team);
                    }

                }
                catch (Exception ex)
                    when(ex is ArgumentException || ex is InvalidOperationException)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
