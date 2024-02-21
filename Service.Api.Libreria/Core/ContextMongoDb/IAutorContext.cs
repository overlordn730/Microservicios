using MongoDB.Driver;
using Servicios.Api.Libreria.Core.Entities;

namespace Servicios.Api.Libreria.Core.ContextMongoDb
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
