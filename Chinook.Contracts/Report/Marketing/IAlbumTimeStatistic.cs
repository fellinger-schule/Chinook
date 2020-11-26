using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public interface IAlbumTimeStatistic
    {
        public Persistence.IAlbum Longest { get; set; }
        public int LongestTime { get; set; }
        public Persistence.IAlbum Shortest { get; set; }
        public int ShortestTime { get; set; }
        public float Avg { get; }
    }
}
