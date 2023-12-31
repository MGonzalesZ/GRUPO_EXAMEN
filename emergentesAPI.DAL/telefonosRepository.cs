﻿using emergentesAPI.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emergentesAPI.DAL;
using emergentesAPI.DAL.DataContext;

namespace emergentesAPI.DAL
{
    public class telefonosRepository
    {
        private readonly DbA9f478TecemergContext _dbContext;
        public telefonosRepository(DbA9f478TecemergContext context)
        {
            _dbContext = context;
        }

        public void Eliminar(int id)
        {
            var telefono = _dbContext.Telefonos.FirstOrDefault(p => p.Id==id);
            if (telefono != null)
            {
                _dbContext.Telefonos.Remove(telefono);
                _dbContext.SaveChanges();
            }
        }

        public Telefono Agregar(string nombre, string numero)
        {
            var modelo = new Telefono()
            {
                Nombre = nombre,
                NumeroTelefonico = numero
            };
            //modelo.Contrasenia = BCrypt.Net.BCrypt.HashPassword(modelo.Contrasenia);
            _dbContext.Telefonos.Add(modelo);
            _dbContext.SaveChanges();
            return modelo;
        }
        //public void Actualizar(Usuario modelo)
        //{
        //    modelo.Contrasenia = BCrypt.Net.BCrypt.HashPassword(modelo.Contrasenia);
        //    _dbContext.Entry(modelo).State = EntityState.Modified;
        //    _dbContext.SaveChanges();
        //}

    }
}
