using RepositioryPattern.Models;
using RepositioryPattern.Repository.Interfaces;

namespace RepositioryPattern.Repository
{
    public class BookRepositoryLinq : IBookRepository
    {
        public void Create(IBook book)
        {
            throw new NotImplementedException();
        }

        public List<Book> Get()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "Book from Linq"
                }
            };
        }

        public Book GetElement(int ID)
        {
            return new Book
            {
                Name = "Book based on ID Linq"
            };
        }

        public void Update(int id, IBook book)
        {
            throw new NotImplementedException();
        }
    }
}
