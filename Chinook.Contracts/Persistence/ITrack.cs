﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface ITrack : IIdentifiable
    { //TrackId;Name;AlbumId;MediaTypeId;GenreId;Composer;Milliseconds;Bytes;UnitPrice
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public float UnitPrice { get; set; }

    }
}
