using FirstAngularProject.Data.Models;

namespace FirstAngularProject.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}
