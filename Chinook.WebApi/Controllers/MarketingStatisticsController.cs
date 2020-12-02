using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingStatisticsController : ControllerBase
    {
        [HttpGet("/api/[controller]/AlbumTimeStatistics")]
        public Contracts.Report.Marketing.IAlbumTimeStatistic GetAlbumTimeStatistics()
        {
            return Report.MarketingReports.GetAlbumTimeStatistics();
        }

        [HttpGet("/api/[controller]/TrackTimeStatistic")]
        public Contracts.Report.Marketing.ITrackTimeStatistic GetTrackTimeStatistic()
        {
            return Report.MarketingReports.GetTrackTimeStatistic();
        }

        [HttpGet("/api/[controller]/TrackSaleStatistic")]
        public Contracts.Report.Marketing.ITrackSaleStatistic GetTrackSaleStatistic()
        {
            return Report.MarketingReports.GetTrackSaleStatistic();
        }
    }
}
