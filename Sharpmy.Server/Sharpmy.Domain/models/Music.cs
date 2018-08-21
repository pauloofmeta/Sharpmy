using System;
using System.Collections.Generic;

namespace Sharpmy.Domain.models
{
    public class Music: ModelBase
    {
        public string Title { get; set; }
        public int Track { get; set; }
        public string FilePath { get; set; }
        public int? Year { get; set; }
        public IEnumerable<Composer> Composers { get; set; }
        public Album Album { get; set; }
        public Guid AlbumId { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}