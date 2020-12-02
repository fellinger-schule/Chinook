/*
 * Fellinger / 4bhif
*/

using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chinook-Marketing! [J. Fellinger / 11]");

			var genres = Logic.Factory.GetAllGenres();
			var artists = Logic.Factory.GetAllArtists();
			var albums = Logic.Factory.GetAllAlbums();

			var artistStatistics = Report.MarketingReports.GetArtistStatistics();

            Console.WriteLine("Track-Zeit-Auswertung");
			var trackTimeStatistic = Report.MarketingReports.GetTrackTimeStatistic();
            Console.WriteLine(String.Format("{0,-60}{1}", "Track/Titel", "Zeit[sec]"));
            Console.WriteLine(String.Format("{0,-60}{1}", trackTimeStatistic.Longest.Name, (int)(trackTimeStatistic.Longest.Milliseconds/1000)));
            Console.WriteLine(String.Format("{0,-60}{1}", trackTimeStatistic.Shortest.Name, (int)(trackTimeStatistic.Shortest.Milliseconds/1000)));
            Console.WriteLine(String.Format("AVG-Time: {0:0.00}", trackTimeStatistic.Avg/1000));
			Console.WriteLine();

			Console.WriteLine("Album-Zeit-Auswertung");
			var albumTimeStatistic = Report.MarketingReports.GetAlbumTimeStatistics();
			Console.WriteLine(String.Format("{0,-60}{1}", "Album/Titel", "Zeit[sec]"));
			Console.WriteLine(String.Format("{0,-60}{1}", albumTimeStatistic.Longest.Title, (int)(albumTimeStatistic.LongestTime / 1000)));
			Console.WriteLine(String.Format("{0,-60}{1}", albumTimeStatistic.Shortest.Title, (int)(albumTimeStatistic.ShortestTime / 1000)));
			Console.WriteLine(String.Format("AVG-Time: {0:0.00}", albumTimeStatistic.Avg / 1000));
            Console.WriteLine();

			Console.WriteLine("Track-Sale-Auswertung");
			var trackSaleStatistic = Report.MarketingReports.GetTrackSaleStatistic();
			Console.WriteLine(String.Format("{0,-60}{1}", "Album/Titel", "Quantity"));
			Console.WriteLine(String.Format("{0,-60}{1}", trackSaleStatistic.MostSold.Name, trackSaleStatistic.MostNumberSold));
			Console.WriteLine(String.Format("{0,-60}{1}", trackSaleStatistic.MostRevenue.Name, trackSaleStatistic.MostNumberSold));
			Console.WriteLine(String.Format("{0,-60}{1}", trackSaleStatistic.LeastSold.Name, trackSaleStatistic.LeastNumberSold));
			Console.WriteLine(String.Format("{0,-60}{1}", trackSaleStatistic.LeastRevenue.Name, trackSaleStatistic.LeastNumberSold));
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}
