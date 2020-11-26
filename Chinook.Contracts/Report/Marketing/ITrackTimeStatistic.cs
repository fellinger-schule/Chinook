using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackTimeStatistic
    {
        public Persistence.ITrack Longest { get; }
        public Persistence.ITrack Shortest { get; }
        public float Avg { get; }
    }
}
