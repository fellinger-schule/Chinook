using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackSaleStatistic
    {
        public Persistence.ITrack MostSold { get; }
        public int MostNumberSold { get; set; }
        public Persistence.ITrack LeastSold { get; }
        public int LeastNumberSold { get; set; }
        public Persistence.ITrack MostRevenue { get; }
        public Persistence.ITrack LeastRevenue { get; }
    }
}
