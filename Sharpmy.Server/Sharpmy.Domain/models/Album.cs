using System.Collections.Generic;

namespace Sharpmy.Domain.models
{
    public class Album: ModelBase
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public IEnumerable<Music> Musics { get; set; }
    }
}