using Sharpmy.Domain.enums;

namespace Sharpmy.Domain.models
{
    public class Picture: ModelBase
    {
        public byte[] Data { get; set; }
        public string Type { get; set; }
        public string MineType { get; set; }
        public string Discription { get; set; }
        public PictureType PictureType { get; set; }
    }
}