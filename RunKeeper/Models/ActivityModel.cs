using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunKeeper.Models
{
    public class ActivityModel
    {
        public DateTime Date { get; set; }
        public string ActivityType { get; set; }
        public string Distance { get; set; }
        public string Duration { get; set; }
        public string AveragePace { get; set; }
        public string AverageSpeed { get; set; }
        public string CaloriesBurned { get; set; }
        public string Climb { get; set; }

    }
}