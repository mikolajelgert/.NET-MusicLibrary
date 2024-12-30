using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace MusicLibrary.Models
{
	public class Song
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }
		[Required]
		public string Author { get; set; }

		public string Genre { get; set; }
		public DateTime AddedOn { get; set; }
	}
}
