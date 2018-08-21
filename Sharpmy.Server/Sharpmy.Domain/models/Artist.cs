using System.Collections.Generic;

namespace Sharpmy.Domain.models
{
    public class Artist: ModelBase
    {
        public string Name { get; set; }

        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Music> Musics { get; set; }
    }
}