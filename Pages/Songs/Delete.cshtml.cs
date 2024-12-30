using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicLibrary.Data;
using MusicLibrary.Models;

namespace MusicLibrary.Pages.Songs
{
    public class DeleteModel : PageModel
    {
		private readonly ApplicationDBContext _db;

		[BindProperty]
		public Song Song { get; set; }
		public DeleteModel(ApplicationDBContext db)
		{
			_db = db;
		}

		public void OnGet(int? id)
		{
			if (id != null && id > 0)
			{
				Song = _db.Songs.Find(id);
			}
		}

		public IActionResult OnPost()
		{
			Song? obj = _db.Songs.Find(Song.Id);
			if (obj == null) return NotFound();

			_db.Songs.Remove(obj);
			_db.SaveChanges();
			return RedirectToPage("/MyList");
		}
	}
}
