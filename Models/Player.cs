﻿namespace BlazorApp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int GameId { get; set; }
        public List<MetricValue> MetricValues { get; set; } = new();
    }
}
