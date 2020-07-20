using System;
using System.Collections.Generic;
using System.Text;

namespace FTLibrary.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ActivityType ActivityType { get; set; }
        public DateTime ActivityStart { get; set; }
        public TimeSpan ActivityDuration { get; set; }
        public double? ActivityDistance { get; set; }
        public string ActivityNotes { get; set; }

        public User User { get; set; }

        
    }
}
