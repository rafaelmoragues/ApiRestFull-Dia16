using ApiRestFull.Repositories;

namespace ApiRestFull.UOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ILibrosRepo libros { get; }
        IAutoresRepo autores { get; }
        void Save();
    }
}
