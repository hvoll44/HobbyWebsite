﻿using System.Collections.Generic;

namespace HobbyWebsite.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<double?> Scores { get; set; } = new List<double?>();

        public Player(string name, int rounds)
        {
            Name = name;

            for (int i = 0; i < rounds; i++)
            {
                Scores.Add(null);
            }
        }

        public Player()
        {
        }
    }
}