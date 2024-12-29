using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models;

namespace MusicLibrary.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
		{
		}

		public DbSet<Song> Songs { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>().HasData(
				new Song { Id = 1, Title = "Sahara", Author = "Hensonn", Genre = "Phonk", AddedOn = new DateTime(2024, 12, 29, 10, 0, 0) },
				new Song { Id = 2, Title = "If We Being Real", Author = "Yeat", Genre = "Lo-Fi", AddedOn = new DateTime(2024, 12, 29, 10, 0, 0) }
			);
		}
	}
}
