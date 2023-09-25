using emergentesAPI.DAL.DataContext;
using emergentesAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emergentesAPI.LN
{
    public class telefonosService
    {
        public Telefono Crear(string nombre, string numerotelefonico)
        {
            return _telefonosRepository.Agregar(nombre, numerotelefonico);
        }
    }
}
