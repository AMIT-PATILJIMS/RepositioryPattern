using Microsoft.AspNetCore.Mvc;
using RepositioryPattern.Models;
using RepositioryPattern.Repository.Interfaces;

namespace RepositioryPattern.Repository
{
    public class BookRepositoryInMemory : IBookRepository
    {
        public void Create(IBook book)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public List<Book> Get()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "Book from InMemory"
                }
            };
        }

        [HttpGet("{id}")]
        public Book GetElement(int ID)
        {
            return new Book 
            {
                Name = "Book based on ID"
            };
        }

        public void Update(int id, IBook book)
        {
            throw new NotImplementedException();
        }
    }
}
