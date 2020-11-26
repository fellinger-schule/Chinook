using Chinook.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
    internal class AlbumTimeStatistic : Contracts.Report.Marketing.IAlbumTimeStatistic
    {
        public IAlbum Longest { get; set; }
        public int LongestTime { get; set; }
        public IAlbum Shortest { get; set; }
        public int ShortestTime { get; set; }
        public float Avg { get; set; }
    }
}
