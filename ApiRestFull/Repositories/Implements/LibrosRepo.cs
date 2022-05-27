using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Repositories.Implements
{
    public class LibrosRepo : GenericRepository<Libros>, ILibrosRepo
    {
        public LibrosRepo(ApplicationDBContext db) : base(db)
        {

        }

        public IEnumerable<Libros> GetLibrosYAutores()
        {
            var aux = _db.Libros.Include(x => x.Autor).ToList();
            return aux;
        }

        public Libros GetLibroYAutor(int id)
        {
            var libro =_db.Libros.Where(x => x.Id == id).Include(x =>x.Autor).FirstOrDefault();
            return libro;
        }
    }
}
