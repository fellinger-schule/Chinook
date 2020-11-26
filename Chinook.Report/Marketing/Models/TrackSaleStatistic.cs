using Chinook.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
    public class TrackSaleStatistic: Contracts.Report.Marketing.ITrackSaleStatistic
    {
        public ITrack MostSold { get; set; }
        public ITrack LeastSold { get; set; }
        public ITrack MostRevenue { get; set; }
        public ITrack LeastRevenue { get; set; }
        public int MostNumberSold { get; set; }
        public int LeastNumberSold { get; set; }
    }
}
