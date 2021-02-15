using System.ComponentModel.DataAnnotations;

namespace PlaylistApi.Models {
    public class Playlist{
        [Key]
        public int SongId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Lenght { get; set; }
        public string Category { get; set; }
    }
}