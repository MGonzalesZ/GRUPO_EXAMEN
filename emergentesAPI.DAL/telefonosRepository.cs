using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emergentesAPI.DAL;
using emergentesAPI.DAL.DataContext;
using emergentesAPI.ENTIDADES;

namespace emergentesAPI.DAL
{
    public class telefonosRepository
    {
        private readonly DbA9f478TecemergContext _dbContext;
        
        public telefonosRepository(DbA9f478TecemergContext context)
        {
            _dbContext = context;
        }

        public Telefono Agregar(string nombre, string numeroTelefonico)
        {
            var modelo = new Telefono()
            {
                
                Nombre = nombre,
                NumeroTelefonico = numeroTelefonico
            };
            _dbContext.Telefonos.Add(modelo);
            _dbContext.SaveChanges();
            return modelo;
        }

        

    }
}
