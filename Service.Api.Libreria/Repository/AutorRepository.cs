using MongoDB.Driver;
using Servicios.Api.Libreria.Core.ContextMongoDb;
using Servicios.Api.Libreria.Core.Entities;

namespace Service.Api.Libreria.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly IAutorContext _autorContext;

        public AutorRepository(IAutorContext autorContext) 
        {
            this._autorContext = autorContext;
        }

        public async Task<IEnumerable<Autor>> GetAutores()
        {
            return await _autorContext.Autores.Find(a => true).ToListAsync();
        }
    }
}
