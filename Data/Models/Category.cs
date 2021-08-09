namespace RareBooks.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Category
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CategoryMaxLenght)]
        public string Name { get; set; }

        public IEnumerable<Book> Books = new List<Book>();
    }
}
