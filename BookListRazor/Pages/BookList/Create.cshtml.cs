using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel (ApplicationDbContext db)
        {
            _db = db;
        }

        //model of Book

        //bindproperty attribute
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {

        }
        //What is passed from Razor page will be passing a book object.
        //Instead of creating a new book object we will bind properties from the book object above.
        public async Task<IActionResult> OnPost()
        {
            //ModelState is...
            if (ModelState.IsValid)
            {
                //Adding the book here if valid.
                await _db.Book.AddAsync(Book);

                //Saved changes to db.
                await _db.SaveChangesAsync();

                //after saved to db, return a redirect to Index Page.
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}