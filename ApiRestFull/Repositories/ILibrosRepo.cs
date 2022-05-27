using ApiRestFull.Entities;

namespace ApiRestFull.Repositories
{
    public interface ILibrosRepo : IGenericRepository<Libros>
    {
        IEnumerable<Libros> GetLibrosYAutores();
        Libros GetLibroYAutor(int id);
    }
}
