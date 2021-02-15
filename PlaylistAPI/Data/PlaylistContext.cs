using Microsoft.EntityFrameworkCore;
using PlaylistApi.Models;

namespace PlaylistAPI.Data {
    public class PlaylistContext : DbContext {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base (options)
        {
            
        }

        public DbSet<Playlist> Playlist {get; set;}
    }
}