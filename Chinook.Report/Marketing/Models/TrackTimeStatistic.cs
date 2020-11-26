using Chinook.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
    internal class TrackTimeStatistic : Contracts.Report.Marketing.ITrackTimeStatistic
    {
        public ITrack Longest { get; set; }
        public ITrack Shortest { get; set; }
        public float Avg { get; set; }
    }
}
