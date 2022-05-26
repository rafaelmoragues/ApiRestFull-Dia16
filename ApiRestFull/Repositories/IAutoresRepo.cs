using ApiRestFull.Entities;

namespace ApiRestFull.Repositories
{
    public interface IAutoresRepo : IGenericRepository<Autor>
    {
        IEnumerable<Autor> GetAutoresYLibros();
    }
}
