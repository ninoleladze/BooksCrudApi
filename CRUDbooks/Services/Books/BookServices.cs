using CRUDbooks.Data;
using CRUDbooks.DTOs;
using CRUDbooks.Models;

namespace CRUDbooks.Services.Books
{
    public class BookServices : IBookServices
    {
        private DataContext DC;
        public BookServices(DataContext db) => DC = db;

        public string CreateBook(CreateBookDto req)
        {
            if (string.IsNullOrWhiteSpace(req.Title))
                return "Book title is required.";
            if (string.IsNullOrWhiteSpace(req.Description))
                return "Book description is required.";
            if (string.IsNullOrWhiteSpace(req.Author))
                return "Book author is required.";

            var book = new Book
            {
                Title = req.Title,
                Description = req.Description,
                Author = req.Author
            };

            DC.Books.Add(book);
            DC.SaveChanges();
            return "Book created successfully!";
        }

        public string DeleteBook(int bookId)
        {
            var book = DC.Books.Find(bookId);
            if (book == null) return "Book not found.";

            DC.Books.Remove(book);
            DC.SaveChanges();

            return "Success";
        }
        public string EditBook(int bookId, UpdateBookDto req)
        {
            var book = DC.Books.Find(bookId);
            if (book == null)
                return "Book not found.";

            if (!string.IsNullOrWhiteSpace(req.Title))
                book.Title = req.Title;
            if (!string.IsNullOrWhiteSpace(req.Description))
                book.Description = req.Description;
            if (!string.IsNullOrWhiteSpace(req.Author))
                book.Author = req.Author;

            DC.SaveChanges();

            return "Book updated successfully!";
        }

        public List<Book> GetBooks()
        {
            return DC.Books.ToList();
        }

    }
}
