using FirstAngularProject.Data.Models;

namespace FirstAngularProject.Data.Services
{
    
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.Find(x => x.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            var book = Data.Books.Find(x => x.Id == id);
            return book;
        }

        public Book UpdateBook(int id, Book newBook)
        {
            var book = Data.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                Data.Books.Remove(book);
                newBook.Id = book.Id;
                Data.Books.Add(newBook);
                return newBook;
            }
            return book;
        }
    }
}

