using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicLibrary.Data;
using MusicLibrary.Models;

namespace MusicLibrary.Pages.Songs
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDBContext _db;

		[BindProperty]
		public Song Song { get; set; }
		public CreateModel(ApplicationDBContext db)
		{
			_db = db;
		}

		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				Song.AddedOn = DateTime.Now;
				_db.Songs.Add(Song);
				_db.SaveChanges();
				return RedirectToPage("/MyList");
			}
			return Page();
		}
    }
}
