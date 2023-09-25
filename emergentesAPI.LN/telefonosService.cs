using emergentesAPI.DAL;
using emergentesAPI.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace emergentesAPI.LN
{
    public class telefonosService
    {
        private telefonosRepository _TelfRepository;
        public telefonosService(telefonosRepository telfRepository)
        {
            _TelfRepository = telfRepository;
        }
        public void Agregar(string nombre, string numeroTelefonico)
        {
            _TelfRepository.Agregar(nombre, numeroTelefonico);
        }

 

        public void Eliminar(int id)
        {
            _TelfRepository.Eliminar(id);
        }
     public List<Telefono> ObtenerTodos()
        {
            return  _TelfRepository.ObtenerTodos();
        }
    }
}
