using ApiRestFull.Entities;
using ApiRestFull.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Repositories.Implements
{
    public class AutoresRepo : GenericRepository<Autor>, IAutoresRepo
    {
        public AutoresRepo(ApplicationDBContext db) : base(db)
        {
                
        }

        public IEnumerable<Autor> GetAutoresYLibros()
        {
            var aux = _db.Autor.Include(x => x.Libros).ToList();
                return aux;
        }
    }
}
