using CRUDbooks.DTOs;
using CRUDbooks.Models;

namespace CRUDbooks.Services.Books
{
    public interface IBookServices
    {
        string CreateBook(CreateBookDto req);
        string DeleteBook(int bookId);
        string EditBook(int bookId, UpdateBookDto req);
        List<Book> GetBooks();

    }
}
