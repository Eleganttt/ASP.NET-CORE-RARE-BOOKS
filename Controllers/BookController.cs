namespace RareBooks.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RareBooks.Data;
    using RareBooks.Models.Books;
    using System.Collections.Generic;
    using System.Linq;

    public class BookController : Controller
    {
        private readonly RareBooksDbContext data;

        public BookController(RareBooksDbContext data) => this.data = data;
        public IActionResult Add() => View(new AddBookFormModel
        {
            Genres = this.GetBookGenres()
        });
        
        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            return View();
        }

        private IEnumerable<BookGenreViewModel> GetBookGenres()
        => this.data
            .Categories
            .Select(b => new BookGenreViewModel
            {
                Id = b.Id,
                Name = b.Name
            })
            .ToList();
    }
}
