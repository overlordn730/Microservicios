﻿using Servicios.Api.Libreria.Core.Entities;

namespace Service.Api.Libreria.Repository
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutores(); 
    }
}
