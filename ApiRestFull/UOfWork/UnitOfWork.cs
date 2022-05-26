﻿using ApiRestFull.Repositories;
using ApiRestFull.Context;

namespace ApiRestFull.UOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _db;
        public ILibrosRepo libros {get; private set;}
        public IAutoresRepo autores { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _db = context;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}