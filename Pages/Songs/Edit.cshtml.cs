using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicLibrary.Data;
using MusicLibrary.Models;

namespace MusicLibrary.Pages.Songs
{
    public class EditModel : PageModel
    {
		private readonly ApplicationDBContext _db;

		[BindProperty]
		public Song Song { get; set; }
		public EditModel(ApplicationDBContext db)
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
			if (ModelState.IsValid)
			{

				_db.Songs.Update(Song);
				_db.SaveChanges();
				return RedirectToPage("/MyList");
			}
			return Page();
		}
	}
}
