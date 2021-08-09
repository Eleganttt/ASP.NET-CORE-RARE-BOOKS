namespace RareBooks.Models.Books
{
    using System.Collections.Generic;
    public class AddBookFormModel
    {
        public string Name { get; init; }

        public decimal Price { get; init; }

        public string ImageURL { get; init; }

        public string Description { get; init; }

        public int GenreId { get; init; }

        public IEnumerable<BookGenreViewModel> Genres { get; set; }
    }
}