using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicLibrary.Data;
using MusicLibrary.Models;

namespace MusicLibrary.Pages
{
    public class MyListModel : PageModel
    {
		public readonly ApplicationDBContext _db;

		public List<Song> SongList { get; set; }

		public MyListModel(ApplicationDBContext db)
		{
			_db = db;
		}

		public void OnGet()
		{
			SongList = _db.Songs.ToList();
		}
	}
}
