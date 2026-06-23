using RepositioryPattern.Models;

namespace RepositioryPattern.Repository.Interfaces
{
    public interface IBookRepository
    {
        List<Book> Get();

        Book GetElement(int ID);

        void Update(int id, IBook book);

        void Create(IBook book);
    }
}
