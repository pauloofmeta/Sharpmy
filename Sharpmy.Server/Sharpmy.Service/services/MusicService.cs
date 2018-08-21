using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Id3;
using Sharpmy.Domain.enums;
using Sharpmy.Domain.models;
using Sharpmy.Service.interfaces;

namespace Sharpmy.Service.services
{
    public class MusicService : ServiceBase, IMusicService
    {
        public List<Music> Musics { get; set; }

        public MusicService()
        {
            Musics = new List<Music>();
        }
        public async Task<bool> CatalogAsync()
        {
            Musics.Clear();

            var files = Directory.GetFiles(@"C:\Musicas", "*.mp3");
            foreach(var file in files)
            {
                using(var music = new Mp3File(file))
                {
                    Id3Tag tag = music.GetTag(Id3TagFamily.Version2x);
                    Musics.Add(new Music{
                        Title = tag.Title.Value,
                        FilePath = file,
                        Track = tag.Track.Value,
                        Artists = tag.Artists.Value.Select(s => new Artist{Name = s}).ToList(),
                        Year = tag.Year.Value,
                        Album = new Album{ Title = tag.Album.Value },
                        Composers = tag.Composers.Value.Select(s => new Composer{Name = s}).ToList(),
                        Pictures = tag.Pictures.Select(pic => new Picture{
                            Discription = pic.Description,
                            Data = pic.PictureData,
                            PictureType = (PictureType)((int)pic.PictureType),
                            MineType = pic.MimeType
                        }).ToList()
                    });
                }
            }

            return Musics.Count > 0;
        }
    }
}