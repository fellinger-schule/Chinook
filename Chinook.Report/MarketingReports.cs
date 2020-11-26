using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Chinook.Report
{
	using IArtistStatistic = Contracts.Report.Marketing.IArtistStatistic;
	using IAlbumTimeStatistic = Contracts.Report.Marketing.IAlbumTimeStatistic;
	using ITrackTimeStatistic = Contracts.Report.Marketing.ITrackTimeStatistic;
	using ITrackSaleStatistic = Contracts.Report.Marketing.ITrackSaleStatistic;

	public class MarketingReports
	{
		public static IEnumerable<IArtistStatistic> GetArtistStatistics()
		{
			var albums = Logic.Factory.GetAllAlbums();
			var artists = Logic.Factory.GetAllArtists();

			// Abfrage 
			// var result = default(IEnumerable<Contracts.Report.Marketing.IArtistStatistic>);
			var result = artists
							.Join(albums,
								  artist => artist.Id,
								  album => album.ArtistId,
								  (artists, albums) => new { Artist = artists, Albums = albums }
							)
							.GroupBy(elm => elm.Artist)
							.Select(group => new Marketing.Models.ArtistStatistic { Name = group.Key.Name, AlbumCount = group.Count() });

			return result;
		}

		public static ITrackTimeStatistic GetTrackTimeStatistic()
		{
			var tracks = Logic.Factory.GetALlTracks();

			var result = new Marketing.Models.TrackTimeStatistic { 
							Longest = tracks.Where(t1 => t1.Milliseconds == tracks.Max(t2 => t2.Milliseconds)).FirstOrDefault(),
							Shortest = tracks.Where(t1 => t1.Milliseconds == tracks.Min(t2 => t2.Milliseconds)).FirstOrDefault(),
							Avg = (float)tracks.Average(t => t.Milliseconds)
			};

			return result;
		}
		public static IAlbumTimeStatistic GetAlbumTimeStatistics()
		{
			var albums = Logic.Factory.GetAllAlbums();
			var tracks = Logic.Factory.GetALlTracks();

			var lengthList = albums.Join(tracks,
								  album => album.Id,
								  tracks => tracks.AlbumId,
								  (albums, tracks) => new { Albums = albums, Tracks = tracks }
								)
								.GroupBy(elm => elm.Albums)
								.Select(group => new { Album = group.Key, TotalTime = group.Sum(elm => elm.Tracks.Milliseconds) })
								.OrderBy(elm => elm.TotalTime);

			var result = new Marketing.Models.AlbumTimeStatistic
			{
				Longest = lengthList.Last().Album,
				LongestTime = lengthList.Last().TotalTime,
				Shortest = lengthList.First().Album,
				ShortestTime = lengthList.First().TotalTime,
				Avg = (float)lengthList.Average(elm => elm.TotalTime)
			};

			return result;

		}

		public static ITrackSaleStatistic GetTrackSaleStatistic()
        {
			var invoiceLines = Logic.Factory.GetAllInvoiceLines();
			var tracks = Logic.Factory.GetALlTracks();

			var numberOfSells = invoiceLines.Join(tracks,
									invoiceLine => invoiceLine.TrackId,
									tracks => tracks.Id,
									(invoiceLine, tracks) => new { InvoiceLine = invoiceLines, Track = tracks }
								)
								.GroupBy(elm => elm.Track)
								.Select(elm => new { Track = elm.Key, NumberSold = elm.Count()})
								.OrderBy(elm => elm.NumberSold);

			var result = new Marketing.Models.TrackSaleStatistic
			{
				MostRevenue = numberOfSells.Last().Track,
				MostNumberSold = numberOfSells.Last().NumberSold,
				MostSold = numberOfSells.Last().Track,
				LeastRevenue = numberOfSells.First().Track,
				LeastNumberSold = numberOfSells.First().NumberSold,
				LeastSold = numberOfSells.First().Track
			};
			return result;
        }
	}
}
